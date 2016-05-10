using System;
using System.Collections.Generic;
using System.Linq;

namespace Abc.NCrafts.Quizz.Performance.Questions._001
{
    [CorrectAnswer(Difficulty = Difficulty.Easy)]
    public class Answer2
    {
        private static readonly HashSet<int> _items;
        private static readonly Random _random;

        static Answer2()
        {
            _items = new HashSet<int>(Enumerable.Range(0, 200));
            _random = new Random();
        }

        public static void Run()
        {
            var value = _random.Next(0, 500);
            // begin
            var hasValue = _items.Contains(value);
            // end
            Logger.Log(hasValue ? "Found!" : "Not found :'(");
        }
    }
}
