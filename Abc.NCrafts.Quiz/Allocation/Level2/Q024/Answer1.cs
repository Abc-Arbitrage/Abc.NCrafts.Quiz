using System;

namespace Abc.NCrafts.Quiz.Allocation.Level2.Q024
{
    [CorrectAnswer]
    public class Answer1
    {
        public static void Run()
        {
            // begin
            var tickCount = Environment.TickCount64;
            var s = $"TickCount: {tickCount}";
            
            ConsumeString(s);
            // end
        }

        private static void ConsumeString(string s)
        {
            Logger.Log(s);
        }
    }
}