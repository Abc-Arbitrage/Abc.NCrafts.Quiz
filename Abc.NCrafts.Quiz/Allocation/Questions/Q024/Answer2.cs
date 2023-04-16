using System;

namespace Abc.NCrafts.Quiz.Allocation.Questions.Q024
{
    public class Answer2
    {
        public static void Run()
        {
            // begin
            var tickCount = Environment.TickCount64;
            var s = (FormattableString)$"TickCount: {tickCount}";
            
            ConsumeString(s);
            // end
        }

        private static void ConsumeString(FormattableString s)
        {
            Logger.Log(s);
        }
    }
}