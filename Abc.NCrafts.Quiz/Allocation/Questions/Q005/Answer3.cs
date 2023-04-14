using System;
using System.Collections.Generic;

namespace Abc.NCrafts.Quiz.Allocation.Questions.Q005
{
    public class Answer3
    {
        private static Dictionary<Key, int> _items = new(100);

        public static void Run()
        {
            _items.Clear();
            
            // begin
            for (var i = 0; i < 100; i++)
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
                => Equals(this, other);

            public override int GetHashCode() 
                => Value;
        }
    }
}