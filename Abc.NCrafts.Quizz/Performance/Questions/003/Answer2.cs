using System.Collections.Generic;
using System.Linq;

namespace Abc.NCrafts.Quizz.Performance.Questions._003
{
    public class Answer2
    {
        private static readonly LinkedList<int> _items;

        static Answer2()
        {
            _items = new LinkedList<int>(Enumerable.Range(0, 200));
        }

        public static void Run()
        {
            // begin
            var sum = _items.Max();
            // end
            Logger.Log("Sum: {0}", sum);
        }
    }
}