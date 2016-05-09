using System;

namespace Abc.NCrafts.Quizz.Questions._009
{
    [CorrectAnswer(Difficulty = Difficulty.Medium)]
    public class Answer1
    {
        private static Random _random = new Random();
        private static int[] _values = { 1, 2, 3 };

        public static void Run()
        {
            // begin
            _values[0] = _random.Next();
            var sum = Sum(_values);
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