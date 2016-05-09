using System;
using System.Collections.Generic;
using System.Linq;

namespace Abc.NCrafts.Quizz.Performance.Questions._004
{
    [CorrectAnswer(Difficulty = Difficulty.Easy)]
    public class Answer2
    {
        private static readonly LinkedList<int> _items = new LinkedList<int>(Enumerable.Range(0, 20));
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
            var node = _items.Find(value);
            if (node == null)
                return;

            _items.Remove(node);
            _items.AddFirst(node);
        }
    }
}