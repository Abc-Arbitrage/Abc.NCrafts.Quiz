using System;
using System.Collections.Generic;
using System.Linq;

namespace Abc.NCrafts.Quizz.Performance.Questions._004
{
    public class Answer1
    {
        private static readonly List<int> _items = Enumerable.Range(0, 20).ToList();
        private static readonly Random _random = new Random();

        public static void Run()
        {
            var value = _random.Next(0, _items.Count);
            // begin
            MoveToFirst(value);
            // end
        }

        private static void MoveToFirst(int value)
        {
            var valueIndex = _items.IndexOf(value);
            if (valueIndex < 0)
                return;

            _items.RemoveAt(valueIndex);
            _items.Insert(0, value);
        }
    }
}