using System;
using System.Collections.Generic;
using System.Linq;

namespace Abc.NCrafts.Quizz.Performance.Questions._004
{
    public class Answer1
    {
        private static readonly List<int> _items;

        static Answer1()
        {
            _items = new List<int>(Enumerable.Range(0, 20));
        }

        public static void Run()
        {
            var value = Random.Shared.Next(0, _items.Count);
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
