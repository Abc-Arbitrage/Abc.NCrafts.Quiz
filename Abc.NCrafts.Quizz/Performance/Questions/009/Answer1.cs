using System;
using System.Linq;
using System.Threading.Tasks;

namespace Abc.NCrafts.Quizz.Performance.Questions._009
{
    [CorrectAnswer(Difficulty = Difficulty.Hard)]
    public class Answer1
    {
        private static readonly Random _random;
        private static readonly int[] _values;

        static Answer1()
        {
            _random = new Random();
            _values = Enumerable.Range(0, 500)
                                .Select(x => _random.Next(5000))
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

            var max = results.Max();
            // end

            Logger.Log("Max: {0}", max);
        }
    }
}