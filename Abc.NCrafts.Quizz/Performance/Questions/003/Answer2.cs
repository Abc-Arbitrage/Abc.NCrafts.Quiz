using System.Collections.Generic;
using System.Linq;

namespace Abc.NCrafts.Quizz.Performance.Questions._003
{
    public class Answer2
    {
        private static readonly LinkedList<int> _items = new LinkedList<int>(Enumerable.Range(0, 200));

        public static void Run()
        {
            var sum = 0;
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