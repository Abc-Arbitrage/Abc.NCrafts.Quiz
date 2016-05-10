using System;
using System.Linq;

namespace Abc.NCrafts.Quizz.Performance.Questions._001
{
    public class Answer1
    {
        private static readonly int[] _items;
        private static readonly Random _random;

        static Answer1()
        {
            _items = Enumerable.Range(0, 200).ToArray();
            _random = new Random();
        }

        public static unsafe void Run()
        {
            var value = _random.Next(0, 500);
            var hasValue = false;
            // begin
            fixed (int* p = _items)
            {
                for (var index = 0; index < _items.Length; index++)
                {
                    if (p[index] == value)
                    {
                        hasValue = true;
                        break;
                    }
                }
            }
            // end
            Logger.Log(hasValue ? "Found!" : "Not found :'(");
        }
    }
}
