using System.Collections.Generic;
using System.Linq;

namespace Abc.NCrafts.Quizz.Performance.Questions._003
{
    [CorrectAnswer(Difficulty = Difficulty.Easy)]
    public class Answer1
    {
        private static readonly List<int> _items;

        static Answer1()
        {
            _items = Enumerable.Range(0, 200).ToList();
        }

        public static void Run()
        {
            // begin
            var sum = _items.Max();
            // end
            Logger.Log("Sum: {0}", sum);
        }
    }
}