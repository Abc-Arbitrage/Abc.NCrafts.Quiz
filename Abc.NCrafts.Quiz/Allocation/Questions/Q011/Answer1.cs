using System.Collections.Generic;
using System.Linq;

namespace Abc.NCrafts.Quiz.Allocation.Questions.Q011
{
    public class Answer1
    {
        private static Queue<int> _values 
            = new Queue<int>(new[] { 1, 2, 3 });

        public static void Run()
        {
            // begin
            var sum = _values.Sum();
            // end

            Logger.Log("Sum: {0}", sum);
        }
    }
}