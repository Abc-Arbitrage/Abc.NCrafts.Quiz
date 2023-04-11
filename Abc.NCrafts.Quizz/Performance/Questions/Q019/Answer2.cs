using System.Collections.Generic;
using System.Linq;

namespace Abc.NCrafts.Quizz.Performance.Questions.Q019
{
    [CorrectAnswer(Difficulty = Difficulty.Medium)]
    public class Answer2
    {
        private static readonly List<int> _values = new List<int>();

        public static void Run()
        {
            _values.Clear();
            _values.AddRange(Enumerable.Range(0, 500));

            // begin
            for (var index = _values.Count - 1; index >= 0;)
            {
                if (_values[index] % 10 != 0)
                {
                    _values.RemoveAt(index);
                }
                index--;
            }
            // end
        }
    }
}