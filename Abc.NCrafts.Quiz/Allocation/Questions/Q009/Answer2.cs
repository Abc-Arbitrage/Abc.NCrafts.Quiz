using System;

namespace Abc.NCrafts.Quiz.Allocation.Questions.Q009
{
    public class Answer2
    {
        public static void Run()
        {
            var random = Random.Shared;
            
            // begin
            var value = random.Next();
            var sum = Sum(value, 2, 3);
            // end

            Logger.Log("Sum: {0}", sum);
        }

        private static int Sum(params int[] values)
        {
            var sum = 0;
            foreach (var value in values)
                sum += value;
            return sum;
        }
    }
}