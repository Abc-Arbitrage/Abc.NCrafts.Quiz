using System.Linq;

namespace Abc.NCrafts.Quiz.Performance.Questions.Q016
{
    public class Answer1
    {
        private static readonly Item[] _values;

        static Answer1()
        {
            _values = Enumerable.Range(0, 1_000_000)
                                .Select(x => new Item(x))
                                .ToArray();
        }

        public static void Run()
        {
            // begin
            for (var i = 0; i < _values.Length; i++)
            {
                _values[i].Product = _values[i].Left * _values[i].Right;
            }
            // end
        }

        private class Item
        {
            public readonly int Left;
            public readonly int Right;
            public int Product;

            public Item(int value)
            {
                Left = value;
                Right = -value;
            }
        }
    }
}
