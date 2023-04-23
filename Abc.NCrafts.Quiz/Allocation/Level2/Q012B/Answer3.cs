namespace Abc.NCrafts.Quiz.Allocation.Level2.Q012B
{
    [CorrectAnswer]
    public class Answer3
    {
        public static void Run()
        {
            // begin
            UseService(new Service());
            // end
        }

        private static void UseService<T>(T service) 
            where T : IService
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
