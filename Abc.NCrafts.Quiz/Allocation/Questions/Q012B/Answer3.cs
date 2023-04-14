using System;

namespace Abc.NCrafts.Quiz.Allocation.Questions.Q012B
{
    [CorrectAnswer(Difficulty = Difficulty.Medium)]
    public class Answer3
    {
        private static Service _service = new(0);

        public static void Run()
        {
            // begin
            UseService(_service with { Id = 5 });
            // end
        }

        private static void UseService(IProgress<int> service)
        {
            service.Report(0);
            service.Report(100);
        }

        private record Service(int Id) : IProgress<int>
        {
            public void Report(int value)
            {
            }
        }
    }
}
