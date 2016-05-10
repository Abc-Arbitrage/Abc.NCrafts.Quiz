using System.Collections.Generic;
using System.Linq;

namespace Abc.NCrafts.Quizz.Performance.Questions._022
{
    [CorrectAnswer(Difficulty = Difficulty.Easy)]
    public class Answer1
    {
        private static readonly List<int> _values;

        static Answer1()
        {
            _values = Enumerable.Range(0, 1000 * 1000).ToList();
        }

        public static void Run()
        {
            var sum = 0L;

            // begin
            for (var i = 0; i < _values.Count; i++)
            {
                sum += i;
            }
            // end

            Logger.Log($"Sum: {sum}");
        }
    }
}
