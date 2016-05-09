using System;

namespace Abc.NCrafts.Quizz.Questions._009
{
    public class Answer2
    {
        private static Random _random = new Random();

        public static void Run()
        {
            // begin
            var random = _random.Next();
            var sum = Sum(random, 2, 3);
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