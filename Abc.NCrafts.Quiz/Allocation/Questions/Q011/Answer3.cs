using System.Collections.Generic;
using System.Linq;

namespace Abc.NCrafts.Quiz.Allocation.Questions.Q011
{
    public class Answer3
    {
        private static Queue<int> _values 
            = new Queue<int>(new[] { 1, 2, 3 });

        public static void Run()
        {
            // begin
            var first = _values.First();
            // end

            Logger.Log("Sum: {0}", first);
        }
    }
}