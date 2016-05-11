using System.Collections.Generic;
using System.Linq;

namespace Abc.NCrafts.Quizz.Performance.Questions._012
{
    [CorrectAnswer(Difficulty = Difficulty.Medium)]
    public class Answer1
    {
        private static readonly List<long> _values;

        static Answer1()
        {
            _values = Enumerable.Range(0, 100 * 1000)
                                .Select(x => (long)x)
                                .ToList();
        }

        public static void Run()
        {
            // begin
            var sum = _values.Sum();
            // end
            Logger.Log("Sum: {0}", sum);
        }
    }
}
