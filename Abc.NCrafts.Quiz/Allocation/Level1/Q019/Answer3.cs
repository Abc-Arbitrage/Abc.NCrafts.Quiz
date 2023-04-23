using System;

namespace Abc.NCrafts.Quiz.Allocation.Level1.Q019
{
    public class Answer3
    {
        public static void Run()
        {
            // begin
            var resource = new NCrafts();
            try
            {
            }
            finally
            {
                if (resource is IDisposable disposable)
                    disposable.Dispose();
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
