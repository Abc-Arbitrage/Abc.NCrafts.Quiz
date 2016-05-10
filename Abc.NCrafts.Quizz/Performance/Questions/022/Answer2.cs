using System.Collections.Generic;
using System.Linq;

namespace Abc.NCrafts.Quizz.Performance.Questions._022
{
    public class Answer2
    {
        private static readonly List<int> _values;

        static Answer2()
        {
            _values = Enumerable.Range(0, 1000 * 1000).ToList();
        }

        public static void Run()
        {
            var sum = 0L;

            // begin
            foreach (var value in _values)
            {
                sum += value;
            }
            // end

            Logger.Log($"Sum: {sum}");
        }
    }
}
