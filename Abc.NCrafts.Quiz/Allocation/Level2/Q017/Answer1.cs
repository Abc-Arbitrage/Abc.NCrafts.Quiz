using System;

namespace Abc.NCrafts.Quiz.Allocation.Level2.Q017
{
    public class Answer1
    {
        public static void Run()
        {
            AddAndLog(Environment.TickCount);

            // begin
            AddAndLog(Environment.TickCount);
            // end
        }

        static void AddAndLog(int ticks)
        {
            var value = Invoke(x => ticks + 2, ticks);
            
            Logger.Log($"Value: {value}");
        }

        static int Invoke(Func<int, int> func, int arg)
        {
            return func.Invoke(arg);
        }
    }
}