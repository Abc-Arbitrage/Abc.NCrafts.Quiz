using System;
using System.Linq;
using System.Threading.Tasks;

namespace Abc.NCrafts.Quiz.Performance1.Level3.Q009
{
    public class Answer1
    {
        private static readonly int[] _values;

        static Answer1()
        {
            var random = new Random();
            _values = Enumerable.Range(0, 500)
                                .Select(x => random.Next(5000))
                                .ToArray();
        }

        public static void Run()
        {
            const int partitionCount = 5;

            var results = new int[partitionCount];

            // begin
            Parallel.For(0, partitionCount, i =>
            {
                for (var index = i; index < _values.Length; index += partitionCount)
                {
                    results[i] += _values[index];
                }
            });

            var max = results.Sum();
            // end

            Logger.Log($"Max: {max}");
        }
    }
}