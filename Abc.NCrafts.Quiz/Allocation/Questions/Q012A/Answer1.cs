using System;

namespace Abc.NCrafts.Quiz.Allocation.Questions.Q012A
{
    public class Answer1
    {
        private static Service _service = new();

        public static void Run()
        {
            // begin
            UseService(_service);
            // end
        }

        private static void UseService(IService service)
        {
            Logger.Log($"Value: {service.GetValue()}");
        }

        private interface IService
        {
            int GetValue();
        }

        private struct Service : IService
        {
            public int GetValue() => 0;
        }
    }
}
