using System.Collections.Generic;
using System.Linq;

namespace Abc.NCrafts.Quiz.Allocation.Questions.Q003
{
    [CorrectAnswer(Difficulty = Difficulty.Medium)]
    public class Answer1
    {
        private static List<int> _values 
            = Enumerable.Range(1, 100).ToList();

        public static void Run()
        {
            // begin
            var sum = Sum(_values);
            // end

            Logger.Log("Sum: {0}", sum);
        }

        private static int Sum(List<int> items)
        {
            var sum = 0;
            foreach (var item in items)
            {
                sum += item;
            }
            return sum;
        }
    }
}
