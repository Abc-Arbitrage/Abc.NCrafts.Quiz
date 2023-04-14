using System;
using System.Collections.Generic;

namespace Abc.NCrafts.Quiz.Allocation.Questions.Q005
{
    [CorrectAnswer(Difficulty = Difficulty.Hard)]
    public class Answer1
    {
        private static Dictionary<Key, int> _items = new(100);

        public static void Run()
        {
            _items.Clear();
            
            // begin
            for (var i = 1; i < 100; i++)
            {
                var key = new Key { Value = i };
                _items[key] = i;
            }
            // end
        }

        private struct Key : IEquatable<Key>
        {
            public int Value;

            public bool Equals(Key other)
                => Value == other.Value;

            public override int GetHashCode() 
                => HashCode.Combine(Value);
        }
    }
}