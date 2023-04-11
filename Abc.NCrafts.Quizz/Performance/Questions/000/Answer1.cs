using System;
using System.Collections.Generic;
using System.Linq;

namespace Abc.NCrafts.Quizz.Performance.Questions._000
{
    public class Answer1
    {
        private static readonly List<int> _items;

        static Answer1()
        {
            _items = Enumerable.Range(0, 200).ToList();
        }

        public static void Run()
        {
            var value = Random.Shared.Next(0, 500);
            // begin
            var hasValue = _items.Contains(value);
            // end
            Logger.Log(hasValue ? "Found!" : "Not found :'(");
        }
    }
}