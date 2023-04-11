using System;

namespace Abc.NCrafts.Quiz.Allocation.Questions.Q019
{
    public class Answer2
    {
        public static void Run()
        {
            // begin
            IDisposable resource = new NCrafts();
            try
            {

            }
            finally
            {
                resource.Dispose();
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
