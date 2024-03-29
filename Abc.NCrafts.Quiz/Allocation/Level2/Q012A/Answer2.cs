﻿namespace Abc.NCrafts.Quiz.Allocation.Level2.Q012A
{
    [CorrectAnswer]
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
            Logger.Log($"Value: {service.GetValue()}");
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
