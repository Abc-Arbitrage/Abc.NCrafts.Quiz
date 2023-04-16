using System;
using System.Buffers;

namespace Abc.NCrafts.Quiz.Allocation.Questions.Q009
{
    [CorrectAnswer(Difficulty = Difficulty.Medium)]
    public class Answer1
    {
        public static void Run()
        {
            var random = Random.Shared;
            int sum;

            // begin
            var values = ArrayPool<int>.Shared.Rent(3);
            values.AsSpan().Clear();
            try
            {
                values[0] = random.Next();
                values[1] = random.Next();
                values[2] = random.Next();

                sum = Sum(values);
            }
            finally
            {
                ArrayPool<int>.Shared.Return(values);
            }
            // end

            Logger.Log($"Sum: {sum}");
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