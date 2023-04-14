using System.Collections.Generic;

namespace Abc.NCrafts.Quiz.Allocation.Questions.Q005
{
    public class Answer2
    {
        private static Dictionary<Key, int> _items 
            = new Dictionary<Key, int>(100);

        public static void Run()
        {
            // begin
            for (var i = 0; i < 100; i++)
            {
                var key = new Key { Value = i };
                _items[key] = i;
            }
            // end
        }

        private struct Key
        {
            public int Value;

            public override bool Equals(object other)
            {
                return other is Key key && Equals(key);
            }

            public bool Equals(Key other)
            {
                return Value == other.Value;
            }

            public override int GetHashCode() { return Value; }
        }
    }
}