using System.Collections.Generic;
using System.Linq;

namespace Abc.NCrafts.Quiz.Performance2.Level1.Q022
{
    [CorrectAnswer]
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
            var values = _values;

            // begin
            for (var i = 0; i < values.Count; i++)
            {
                sum += values[i];
            }
            // end

            Logger.Log($"Sum: {sum}");
        }
    }
}
