using System;

namespace Abc.NCrafts.Quizz.Questions._019
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
