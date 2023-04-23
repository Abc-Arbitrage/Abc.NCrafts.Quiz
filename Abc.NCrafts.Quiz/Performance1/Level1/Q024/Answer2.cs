using System;

namespace Abc.NCrafts.Quiz.Performance1.Level1.Q024
{
    [CorrectAnswer]
    public class Answer2
    {
        public static void Run()
        {
            // begin
            var now = DateTime.UtcNow;
            // end

            Logger.Log($"Now: {now}");
        }
    }
}