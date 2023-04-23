using System.Collections.Generic;
using System.Linq;

namespace Abc.NCrafts.Quiz.Performance1.Level1.Q002
{
    [CorrectAnswer]
    public class Answer1
    {
        private static List<double> _items;

        static Answer1()
        {
            _items = Enumerable.Repeat(42.0, 50)
                               .ToList();
        }

        public static void Run()
        {
            // begin
            var sum = _items.Sum();
            // end
            
            Logger.Log($"Sum: {sum}");
        }
    }
}
