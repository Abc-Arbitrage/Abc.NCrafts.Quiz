using System;
using System.Linq;

namespace Abc.NCrafts.Quizz.Questions._009
{
    public class Answer3
    {
        private static Random _random = new Random();

        public static void Run()
        {
            // begin
            var sum = Sum(Array.Empty<int>().ToArray());
            sum += _random.Next();
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