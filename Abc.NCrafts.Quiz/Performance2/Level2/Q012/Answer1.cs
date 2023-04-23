using System.Collections.Generic;
using System.Linq;

namespace Abc.NCrafts.Quiz.Performance2.Level2.Q012
{
    [CorrectAnswer]
    public class Answer1
    {
        private static List<long> _values;

        static Answer1()
        {
            _values = Enumerable.Range(0, 100_000)
                                .Select(x => (long)x)
                                .ToList();
        }

        public static void Run()
        {
            // begin
            var sum = _values.Sum();
            // end
            Logger.Log($"Sum: {sum}");
        }
    }
}
