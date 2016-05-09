using System;
using System.Collections.Generic;
using System.Linq;

namespace Abc.NCrafts.Quizz.Performance.Questions._000
{
    public class Answer1
    {
        private static readonly List<int> _items = Enumerable.Range(0, 200).ToList();
        private static readonly Random _random = new Random();

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