using System.Collections.Generic;
using System.Linq;

namespace Abc.NCrafts.Quizz.Performance.Questions._002
{
    public class Answer2
    {
        private static readonly List<decimal> _items;

        static Answer2()
        {
            _items = Enumerable.Repeat(42m, 50).ToList();
        }

        public static void Run()
        {
            var sum = 0m;
            // begin
            foreach (var item in _items)
            {
                sum += item;
            }
            // end
            Logger.Log("Sum: {0}", sum);
        }
    }
}
