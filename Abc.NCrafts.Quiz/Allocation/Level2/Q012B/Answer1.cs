namespace Abc.NCrafts.Quiz.Allocation.Level2.Q012B
{
    public class Answer1
    {
        public static void Run()
        {
            // begin
            UseService(new Service());
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
