using System;

namespace Abc.NCrafts.Quizz.Questions._020
{
    [CorrectAnswer(Difficulty = Difficulty.Easy)]
    public class Answer1
    {
        public static void Run()
        {
            // begin
            var d1 = new DateTime(1983, 03, 02);
            Nullable<DateTime> nullableDate = d1;
            var d2 = nullableDate.GetValueOrDefault().Date;
            // end

            Logger.Log("Date: ", d2);
        }
    }
}
