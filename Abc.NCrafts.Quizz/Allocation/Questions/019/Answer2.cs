using System;

namespace Abc.NCrafts.Quizz.Questions._019
{
    public class Answer2
    {
        public static void Run()
        {
            // begin
            IDisposable ressource = new NCrafts();
            try
            {

            }
            finally
            {
                ressource.Dispose();
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
