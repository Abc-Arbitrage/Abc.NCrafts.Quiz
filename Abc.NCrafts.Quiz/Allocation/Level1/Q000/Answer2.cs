using System;

namespace Abc.NCrafts.Quiz.Allocation.Level1.Q000
{
    [CorrectAnswer]
    public class Answer2
    {
        public static void Run()
        {
            // begin
            var date = new DateOnly(1983, 03, 02);
            // end
            
            Logger.Log($"Date: {date}");
        }
    }
}