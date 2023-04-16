using System;

namespace Abc.NCrafts.Quiz.Allocation.Questions.Q017
{
    [CorrectAnswer(Difficulty = Difficulty.Medium)]
    public class Answer2
    {
        public static void Run()
        {
            var ticks = 1_000;
            var d1 = Invoke(x => new DateTime(x), ticks);

            // begin
            var d2 = Invoke(x => new DateTime(x), ticks);
            // end

            Logger.Log($"Date 1: {d1}");
            Logger.Log($"Date 2: {d2}");
        }

        private static DateTime Invoke(Func<long, DateTime> builder, long ticks)
        {
            return builder.Invoke(ticks);
        }
    }
}