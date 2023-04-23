using System.Collections.Generic;
using System.Linq;

namespace Abc.NCrafts.Quiz.Allocation.Level3.Q011
{
    [CorrectAnswer]
    public class Answer2
    {
        private static Queue<int> _values = new(new[] { 1, 2, 3 });

        public static void Run()
        {
            // begin
            var count = _values.Count();
            // end

            Logger.Log($"Count: {count}");
        }
    }
}