using System.Collections.Generic;
using System.Linq;

namespace Abc.NCrafts.Quizz.Performance.Questions.Q019
{
    public class Answer1
    {
        private static readonly List<int> _values = new List<int>();

        public static void Run()
        {
            _values.Clear();
            _values.AddRange(Enumerable.Range(0, 500));

            // begin
            for (var index = 0; index < _values.Count; )
            {
                if (_values[index] % 10 != 0)
                {
                    _values.RemoveAt(index);
                }
                else
                {
                    index++;
                }
            }
            // end
        }
    }
}