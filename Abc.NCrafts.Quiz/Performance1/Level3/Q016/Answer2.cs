using System.Linq;

namespace Abc.NCrafts.Quiz.Performance1.Level3.Q016
{
    [CorrectAnswer]
    public class Answer2
    {
        private static readonly Item[] _values;

        static Answer2()
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

        private struct Item
        {
            public readonly int Left;
            public readonly int Right;
            public int Product;

            public Item(int value)
            {
                Left = value;
                Right = -value;
                Product = 0;
            }
        }
    }
}
