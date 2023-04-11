using System;

namespace Abc.NCrafts.Quiz.Allocation.Questions.Q019
{
    [CorrectAnswer(Difficulty = Difficulty.Easy)]
    public class Answer1
    {
        public static void Run()
        {
            // begin
            using (var resource = new NCrafts())
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
