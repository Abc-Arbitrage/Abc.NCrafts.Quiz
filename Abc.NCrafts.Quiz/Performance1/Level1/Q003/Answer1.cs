using System.Collections.Generic;
using System.Linq;

namespace Abc.NCrafts.Quiz.Performance1.Level1.Q003
{
    [CorrectAnswer]
    public class Answer1
    {
        private static List<int> _items;

        static Answer1()
        {
            var items = Enumerable.Range(0, 200);
            _items = new List<int>(items);
        }

        public static void Run()
        {
            // begin
            var max = _items.Max();
            // end
            
            Logger.Log($"Max: {max}");
        }
    }
}