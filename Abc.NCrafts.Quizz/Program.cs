using System;
using System.Diagnostics;
using System.Linq;

namespace Abc.NCrafts.Quizz
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            RunPerformanceQuestion("025", 1000);
            //RunPerformanceQuestion("010", 100 * 1000);
            //RunPerformanceQuestion("006", 100);

            Console.ReadLine();
        }

        private static void RunPerformanceQuestion(string number, int iterationCount = 2 * 1000 * 1000)
        {
            Console.WriteLine("Running " + number);
            Console.WriteLine();

            var types = typeof(Program).Assembly.GetTypes().Where(x => x.Namespace != null && x.Namespace.Contains("Performance") && x.Namespace.EndsWith(number) && !x.IsNested);

            foreach (var type in types)
            {
                var runDelegate = (Action)type.GetMethod("Run").CreateDelegate(typeof(Action));

                var stopwatch = Stopwatch.StartNew();

                for (var i = 0; i < iterationCount; i++)
                {
                    runDelegate();
                }
                
                stopwatch.Stop();

                Console.WriteLine($"{number}/{type.Name}: {stopwatch.Elapsed}");
            }
        }

        private static void RunAllocationQuestion(string number)
        {
            Console.WriteLine("Running " + number);
            Console.WriteLine();

            var types = typeof(Program).Assembly.GetTypes().Where(x => x.Namespace != null && x.Namespace.Contains("Allocation") && x.Namespace.EndsWith(number) && !x.IsNested);

            foreach (var type in types)
            {
                var runDelegate = (Action)type.GetMethod("Run").CreateDelegate(typeof(Action));

                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();

                var gcCount = GC.CollectionCount(0);
                for (var i = 0; i < 10 * 1000 * 1000; i++)
                {
                    runDelegate();
                }
                gcCount = GC.CollectionCount(0) - gcCount;

                Console.WriteLine($"{number}/{type.Name}: {gcCount,5:N0} gen 0 collection(s).");
            }
        }
    }
}