using System;
using System.Linq;

namespace Abc.NCrafts.Quizz.Performance.Questions._013
{
    [CorrectAnswer(Difficulty = Difficulty.Hard)]
    public class Answer2
    {
        private static readonly int[] _values;
        private static readonly int _threshold;

        static Answer2()
        {
            _threshold = 42;
            _values = Enumerable.Range(0, 100 * 1000)
                                .OrderBy(_ => Guid.NewGuid())
                                .ToArray();
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
