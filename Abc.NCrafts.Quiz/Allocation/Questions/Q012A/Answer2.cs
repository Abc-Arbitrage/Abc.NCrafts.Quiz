using System;

namespace Abc.NCrafts.Quiz.Allocation.Questions.Q012A
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

        private static void UseService(IService service)
        {
            Logger.Log("Value: {0}", service.GetValue());
        }

        private interface IService
        {
            int GetValue();
        }

        private class Service : IService
        {
            public int GetValue() => 0;
        }
    }
}
