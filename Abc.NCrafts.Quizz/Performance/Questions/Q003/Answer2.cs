using System.Collections.Generic;
using System.Linq;

namespace Abc.NCrafts.Quizz.Performance.Questions.Q003
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
            var max = _items.Max();
            // end
            Logger.Log("Max: {0}", max);
        }
    }
}