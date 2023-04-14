using System;

namespace Abc.NCrafts.Quiz.Allocation.Questions.Q010
{
    public class Answer2
    {
        public static void Run()
        {
            // begin
            var values = GetValues();
            var sum = values.Item1 + values.Item2;
            // end

            Logger.Log("Sum: {0}", sum);
        }

        private static Tuple<int, int> GetValues()
            => Tuple.Create(10, 42);
    }
}