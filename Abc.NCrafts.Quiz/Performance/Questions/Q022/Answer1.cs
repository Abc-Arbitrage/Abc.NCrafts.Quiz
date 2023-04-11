using System.Collections.Generic;
using System.Linq;

namespace Abc.NCrafts.Quiz.Performance.Questions.Q022
{
    [CorrectAnswer(Difficulty = Difficulty.Easy)]
    public class Answer1
    {
        private static readonly List<int> _values;

        static Answer1()
        {
            _values = Enumerable.Range(0, 1_000_000)
                                .ToList();
        }

        public static void Run()
        {
            var sum = 0L;

            // begin
            for (var i = 0; i < _values.Count; i++)
            {
                sum += _values[i];
            }
            // end

            Logger.Log($"Sum: {sum}");
        }
    }
}
