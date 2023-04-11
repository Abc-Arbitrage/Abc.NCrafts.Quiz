using System;
using System.Linq;

namespace Abc.NCrafts.Quiz.Allocation.Questions.Q009
{
    public class Answer3
    {
        public static void Run()
        {
            var random = Random.Shared;
            
            // begin
            var sum = Sum();
            sum += random.Next();
            // end

            Logger.Log("Sum: {0}", sum);
        }

        private static int Sum(params int[] values)
        {
            var sum = 0;
            foreach (var value in values.AsEnumerable())
                sum += value;
            return sum;
        }
    }
}