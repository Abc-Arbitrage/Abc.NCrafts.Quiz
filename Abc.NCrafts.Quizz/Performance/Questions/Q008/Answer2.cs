using System;
using System.Linq;

namespace Abc.NCrafts.Quizz.Performance.Questions.Q008
{
    [CorrectAnswer(Difficulty = Difficulty.Hard)]
    public class Answer2
    {
        private static readonly short[] _values;

        static Answer2()
        {
            var random = new Random();
            _values = Enumerable.Range(0, 100)
                                .Select(x => (short)random.Next(5000))
                                .ToArray();
        }

        public static void Run()
        {
            // begin
            short max1 = 0;
            short max2 = 0;
            for (var index = 0; index < _values.Length; index+=2)
            {
                max1 = Math.Max(max1, _values[index]);
                max2 = Math.Max(max2, _values[index + 1]);
            }
            short max = Math.Max(max1, max2);
            // end
            Logger.Log("Max: {0}", max);
        }
    }
}