using System;

namespace Abc.NCrafts.Quiz.Allocation.Level1.Q019
{
    [CorrectAnswer]
    public class Answer1
    {
        public static void Run()
        {
            // begin
            using (var resource = new Scope())
            {
            }
            // end
        }

        private struct Scope : IDisposable
        {
            public void Dispose()
            {
            }
        }
    }
}
