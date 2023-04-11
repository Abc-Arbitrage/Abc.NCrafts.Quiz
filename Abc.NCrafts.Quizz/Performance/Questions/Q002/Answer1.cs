using System.Collections.Generic;
using System.Linq;

namespace Abc.NCrafts.Quizz.Performance.Questions.Q002
{
    [CorrectAnswer(Difficulty = Difficulty.Easy)]
    public class Answer1
    {
        private static readonly List<double> _items;

        static Answer1()
        {
            _items = Enumerable.Repeat(42.0, 50)
                               .ToList();
        }

        public static void Run()
        {
            // begin
            var sum = _items.Sum();
            // end
            Logger.Log("Sum: {0}", sum);
        }
    }
}
