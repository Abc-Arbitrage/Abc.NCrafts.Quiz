using System;

namespace Abc.NCrafts.Quizz.Questions._019
{
    [CorrectAnswer(Difficulty = Difficulty.Easy)]
    public class Answer1
    {
        public static void Run()
        {
            // begin
            using (var ressource = new NCrafts())
            {
            }
            // end
        }

        private struct NCrafts : IDisposable
        {
            public void Dispose()
            {
            }
        }
    }
}
