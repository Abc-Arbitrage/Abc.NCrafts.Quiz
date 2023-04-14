using System;

namespace Abc.NCrafts.Quiz.Allocation.Questions.Q017
{
    public class Answer1
    {
        public static void Run()
        {
            var ticks = 1_000;
            var d1 = Invoke(x => new DateTime(ticks), ticks);

            // begin
            var d2 = Invoke(x => new DateTime(ticks), ticks);
            // end

            Logger.Log("Date 1: {0}", d1);
            Logger.Log("Date 2: {0}", d2);
        }

        private static DateTime Invoke(Func<long, DateTime> builder, long ticks)
        {
            return builder.Invoke(ticks);
        }
    }
}