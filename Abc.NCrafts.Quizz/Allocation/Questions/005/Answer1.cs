using System;
using System.Collections.Generic;

namespace Abc.NCrafts.Quizz.Questions._005
{
    [CorrectAnswer(Difficulty = Difficulty.Hard)]
    public class Answer1
    {
        private static Dictionary<Key, int> _items 
            = new Dictionary<Key, int>(99);

        public static void Run()
        {
            // begin
            for (var i = 1; i < 100; i++)
            {
                var key = new Key(i);
                _items[key] = i;
            }
            // end
        }

        private struct Key : IEquatable<Key>
        {
            public readonly int Value;
            public Key(int value) { Value = value; }
            public override bool Equals(object other)
            {
                return Equals((Key)other);
            }
            public bool Equals(Key other)
            {
                return Value == other.Value;
            }
            public override int GetHashCode() { return Value; }
        }
    }
}