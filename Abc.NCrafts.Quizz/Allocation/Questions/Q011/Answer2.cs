using System.Collections.Generic;
using System.Linq;

namespace Abc.NCrafts.Quizz.Allocation.Questions.Q011
{
    [CorrectAnswer(Difficulty = Difficulty.Hard)]
    public class Answer2
    {
        private static Queue<int> _values 
            = new Queue<int>(new[] { 1, 2, 3 });

        public static void Run()
        {
            // begin
            var count = _values.Count();
            // end

            Logger.Log("Count: {0}", count);
        }
    }
}