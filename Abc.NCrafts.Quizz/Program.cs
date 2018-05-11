using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Abc.NCrafts.Quizz
{
    internal class Program
    {
        private static void Main()
        {
            LogInfo();

            //RunPerformanceQuestion("Performance2018", 1, 50_000);
            RunPerformance2018Benchmarks();

            Console.WriteLine();
        }

        private static unsafe void LogInfo()
        {
            Console.WriteLine(RuntimeInformation.FrameworkDescription);
            Console.WriteLine(Path.GetFileName(RuntimeEnvironment.GetRuntimeDirectory().TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar)));
            Console.WriteLine($"{sizeof(IntPtr) * 8}-bit");
            Console.WriteLine($"Vector size: {Vector<byte>.Count} bytes");
            Console.WriteLine($"Intrinsics: SSE: {Sse.IsSupported}, SSE2: {Sse2.IsSupported}, SSE3: {Sse3.IsSupported}, SSSE3: {Ssse3.IsSupported}, SEE4.1: {Sse41.IsSupported}, SSE4.2: {Sse42.IsSupported}, AVX: {Avx.IsSupported}, AVX2: {Avx2.IsSupported}, LZCNT: {Lzcnt.IsSupported}, POPCNT: {Popcnt.IsSupported}");
            Console.WriteLine();
        }

        private static void RunPerformance2018Benchmarks()
        {
            var types = typeof(Program).Assembly
                                       .GetTypes()
                                       .Where(type => type.IsPublic
                                                      && type.Namespace != null
                                                      && type.Namespace.StartsWith("Abc.NCrafts.Quizz.Performance2018")
                                                      && type.GetMethods().Any(m => m.IsDefined(typeof(BenchmarkAttribute))))
                                       .OrderBy(t => t.Namespace)
                                       .ToArray();

            BenchmarkSwitcher.FromTypes(types).Run();
        }

        private static void RunPerformanceQuestion(string ns, int number, long iterationCount = 2_000_000)
        {
            Console.WriteLine($"Running {ns}: {number}");
            Console.WriteLine();

            var types = typeof(Program).Assembly.GetTypes().Where(x => x.Namespace != null && x.Namespace == $"Abc.NCrafts.Quizz.{ns}.Questions._{number:000}" && !x.IsNested);
            var durationOfFirstAnswer = (TimeSpan?)null;

            foreach (var type in types)
            {
                var instance = Activator.CreateInstance(type);
                var runMethod = type.GetMethod("Run", BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static) ?? throw new InvalidOperationException();

                var runDelegate = runMethod.IsStatic
                    ? (Action)runMethod.CreateDelegate(typeof(Action))
                    : (Action)runMethod.CreateDelegate(typeof(Action), instance);

                Console.WriteLine($"{number:000}/{type.Name}:");
                Logger.Enabled = true;
                runDelegate();
                Logger.Enabled = false;

                for (var i = 0; i < 10; i++)
                    runDelegate();

                var stopwatch = Stopwatch.StartNew();

                for (var i = 0; i < iterationCount; i++)
                    runDelegate();

                stopwatch.Stop();

                if (durationOfFirstAnswer == null)
                {
                    durationOfFirstAnswer = stopwatch.Elapsed;
                    Console.WriteLine($"=> {stopwatch.Elapsed}");
                }
                else
                {
                    var previousTicks = durationOfFirstAnswer.Value.Ticks;
                    var newTicks = stopwatch.Elapsed.Ticks;
                    var increase = (newTicks - previousTicks) / (double)previousTicks;
                    Console.WriteLine($"=> {stopwatch.Elapsed} ({increase:P0})");
                }

                Console.WriteLine();
            }
        }

        private static void RunAllocationQuestion(string number)
        {
            Console.WriteLine($"Running {number}");
            Console.WriteLine();

            var types = typeof(Program).Assembly.GetTypes().Where(x => x.Namespace != null && !x.Namespace.Contains("Performance") && x.Namespace.EndsWith(number) && !x.IsNested);

            foreach (var type in types)
            {
                var runDelegate = (Action)type.GetMethod("Run")?.CreateDelegate(typeof(Action)) ?? throw new InvalidOperationException();

                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();

                var gcCount = GC.CollectionCount(0);
                for (var i = 0; i < 10 * 1000 * 1000; i++)
                    runDelegate();

                gcCount = GC.CollectionCount(0) - gcCount;

                Console.WriteLine($"{number}/{type.Name}: {gcCount,5:N0} gen 0 collection(s).");
            }
        }
    }
}
