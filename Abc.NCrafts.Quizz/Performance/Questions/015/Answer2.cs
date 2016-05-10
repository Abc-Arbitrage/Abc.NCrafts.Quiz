using System;
using System.Linq;

namespace Abc.NCrafts.Quizz.Performance.Questions._015
{
    [CorrectAnswer(Difficulty = Difficulty.Hard)]
    public class Answer2
    {
        private static readonly int _threshold;
        private static readonly int[] _values;

        static Answer2()
        {
            _threshold = _values.Length / 2;
            _values = Enumerable.Range(0, 1000 * 1000).ToArray();
        }

        public static void Run()
        {
            var count = 0;

            // begin
            for (var i = 0; i < _values.Length; i++)
            {
                if (_values[i] > _threshold)
                    count++;
            }
            // end

            Logger.Log($"{count} values greater than {_threshold}");
        }
    }
}
