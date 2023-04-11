using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abc.NCrafts.Quizz.Performance.Questions.Q009
{
    [CorrectAnswer(Difficulty = Difficulty.Hard)]
    public class Answer2
    {
        private static readonly int[] _values;

        static Answer2()
        {
            var random = new Random();
            _values = Enumerable.Range(0, 500)
                                .Select(x => random.Next(5000))
                                .ToArray();
        }

        public static void Run()
        {
            const int partitionCount = 5;

            var results = new List<int>();

            // begin
            Parallel.For(0, partitionCount, i =>
            {
                var localResult = 0;
                for (var index = i; index < _values.Length; index += partitionCount)
                {
                    localResult += _values[index];
                }

                lock (results)
                {
                    results.Add(localResult);
                }
            });

            var max = results.Sum();
            // end

            Logger.Log("Max: {0}", max);
        }
    }
}
