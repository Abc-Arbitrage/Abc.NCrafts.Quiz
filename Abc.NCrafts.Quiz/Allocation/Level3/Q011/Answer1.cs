using System.Collections.Generic;
using System.Linq;

namespace Abc.NCrafts.Quiz.Allocation.Level3.Q011
{
    public class Answer1
    {
        private static Queue<int> _values = new(new[] { 1, 2, 3 });

        public static void Run()
        {
            // begin
            var sum = _values.Sum();
            // end

            Logger.Log($"Sum: {sum}");
        }
    }
}