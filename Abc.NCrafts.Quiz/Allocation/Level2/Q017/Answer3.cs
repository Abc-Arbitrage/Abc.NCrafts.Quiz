using System;

namespace Abc.NCrafts.Quiz.Allocation.Level2.Q017
{
    public class Answer3
    {
        public static void Run()
        {
            RunImpl(Environment.TickCount);

            // begin
            RunImpl(Environment.TickCount);
            // end
        }

        static void RunImpl(int ticks)
        {
            var value = Invoke(() => ticks + 2);
            
            Logger.Log($"Value: {value}");
        }

        static int Invoke(Func<int> func)
        {
            return func.Invoke();
        }
    }
}