using System;
using System.Linq;

namespace Abc.NCrafts.Quizz
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Run("011");

            Console.ReadLine();
        }

        public static void Run(string number)
        {
            Console.WriteLine("Running " + number);
            Console.WriteLine();

            var types = typeof(Program).Assembly.GetTypes().Where(x => x.Namespace != null && x.Namespace.EndsWith(number) && !x.IsNested);

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

                Console.WriteLine("{0}/{1} : {2,5:N0} gen 0 collection(s).", number, type.Name, gcCount);
            }
        }
    }
}
