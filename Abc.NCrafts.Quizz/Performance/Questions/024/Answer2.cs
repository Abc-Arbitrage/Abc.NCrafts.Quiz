using System;

namespace Abc.NCrafts.Quizz.Performance.Questions._024
{
    [CorrectAnswer(Difficulty = Difficulty.Easy)]
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