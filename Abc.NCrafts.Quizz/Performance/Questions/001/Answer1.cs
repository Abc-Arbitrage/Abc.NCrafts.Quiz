using System;
using System.Linq;

namespace Abc.NCrafts.Quizz.Performance.Questions._001
{
    public class Answer1
    {
        private static readonly int[] _items;

        static Answer1()
        {
            _items = Enumerable.Range(0, 200).ToArray();
        }

        public static void Run()
        {
            var value = Random.Shared.Next(0, 500);
            // begin
            var hasValue = _items.AsSpan().IndexOf(value) != -1;
            // end
            Logger.Log(hasValue ? "Found!" : "Not found :'(");
        }
    }
}
