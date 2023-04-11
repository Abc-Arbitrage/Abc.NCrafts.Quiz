using System;
using System.Linq;

namespace Abc.NCrafts.Quizz.Performance.Questions.Q008
{
    public class Answer1
    {
        private static readonly short[] _values;

        static Answer1()
        {
            var random = new Random();
            _values = Enumerable.Range(0, 100)
                                .Select(x => (short)random.Next(5000))
                                .ToArray();
        }

        public static void Run()
        {
            // begin
            short max = 0;
            for (var index = 0; index < _values.Length; index++)
            {
                max = Math.Max(max, _values[index]);
            }
            // end
            Logger.Log("Max: {0}", max);
        }
    }
}