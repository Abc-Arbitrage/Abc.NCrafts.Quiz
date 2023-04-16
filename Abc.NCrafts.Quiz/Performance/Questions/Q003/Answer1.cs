using System.Collections.Generic;
using System.Linq;

namespace Abc.NCrafts.Quiz.Performance.Questions.Q003
{
    [CorrectAnswer(Difficulty = Difficulty.Easy)]
    public class Answer1
    {
        private static readonly List<int> _items;

        static Answer1()
        {
            _items = new List<int>(Enumerable.Range(0, 200));
        }

        public static void Run()
        {
            // begin
            var max = _items.Max();
            // end
            Logger.Log($"Max: {max}");
        }
    }
}