using System;

namespace Abc.NCrafts.Quizz.Questions._019
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
                var disposableResource = resource as IDisposable;
                if (disposableResource != null)
                    disposableResource.Dispose();
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
