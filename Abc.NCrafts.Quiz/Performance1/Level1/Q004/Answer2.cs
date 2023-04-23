using System;
using System.Collections.Generic;
using System.Linq;

namespace Abc.NCrafts.Quiz.Performance1.Level1.Q004
{
    [CorrectAnswer]
    public class Answer2
    {
        private static LinkedList<int> _items;

        static Answer2()
        {
            _items = new LinkedList<int>(Enumerable.Range(0, 20));
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
            var node = _items.Find(value);
            if (node == null)
                return;

            _items.Remove(node);
            _items.AddFirst(node);
        }
    }
}
