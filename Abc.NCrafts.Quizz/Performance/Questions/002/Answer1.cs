using System.Collections.Generic;
using System.Linq;

namespace Abc.NCrafts.Quizz.Performance.Questions._002
{
    [CorrectAnswer(Difficulty = Difficulty.Easy)]
    public class Answer1
    {
        private static readonly List<double> _items = Enumerable.Repeat(42.0, 50).ToList();

        public static void Run()
        {
            var sum = 0.0;
            // begin
            foreach (var item in _items)
            {
                sum += item;
            }
            // end
            Logger.Log("Sum: {0}", sum);
        }
    }
}