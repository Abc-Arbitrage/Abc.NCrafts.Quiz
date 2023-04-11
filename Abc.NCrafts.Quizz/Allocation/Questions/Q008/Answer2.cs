using System;

namespace Abc.NCrafts.Quizz.Allocation.Questions.Q008
{
    [CorrectAnswer(Difficulty = Difficulty.Easy)]
    public class Answer2
    {
        public static void Run()
        {
            // begin
            var status = (Status)6;
            var isDefined = (status & Status.S2) != 0;
            if (!isDefined)
                Console.WriteLine("Allocation!");
            // end

            Logger.Log("Status: {0}", status);
        }

        [Flags]
        private enum Status
        {
            None = 0,
            S1 = 1,
            S2 = 2,
            S3 = 4,
        }
    }
}