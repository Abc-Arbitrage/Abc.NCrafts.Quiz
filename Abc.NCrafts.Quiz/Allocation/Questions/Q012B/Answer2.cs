using System;

namespace Abc.NCrafts.Quiz.Allocation.Questions.Q012B
{
    public class Answer2
    {
        private static Service _service = new();

        public static void Run()
        {
            // begin
            UseService(_service);
            // end
        }

        private static void UseService(IProgress<int> service)
        {
            service.Report(0);
            service.Report(100);
        }

        private class Service : IProgress<int>
        {
            public void Report(int value)
            {
            }
        }
    }
}
