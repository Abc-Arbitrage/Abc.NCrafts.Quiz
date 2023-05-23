using System;

namespace Abc.NCrafts.Quiz.Allocation.Level2.Q017
{
    [CorrectAnswer]
    public class Answer2
    {
        public static void Run()
        {
            RunImpl(Environment.TickCount);

            // begin
            RunImpl(Environment.TickCount);
            // end
        }

        private static void RunImpl(int ticks)
        {
            var value = Invoke(x => x + 2, ticks);
            
            Logger.Log($"Value: {value}");
        }

        static int Invoke(Func<int, int> func, int ticks)
        {
            return func.Invoke(ticks);
        }
    }
}