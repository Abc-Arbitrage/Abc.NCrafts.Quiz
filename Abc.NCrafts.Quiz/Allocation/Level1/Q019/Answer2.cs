using System;

namespace Abc.NCrafts.Quiz.Allocation.Level1.Q019
{
    public class Answer2
    {
        public static void Run()
        {
            // begin
            IDisposable resource = new Scope();
            try
            {

            }
            finally
            {
                resource.Dispose();
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
