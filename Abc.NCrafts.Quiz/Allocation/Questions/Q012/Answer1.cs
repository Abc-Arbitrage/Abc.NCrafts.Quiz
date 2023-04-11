namespace Abc.NCrafts.Quiz.Allocation.Questions.Q012
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
            service.Do();
        }

        private interface IService
        {
            void Do();
        }

        private struct Service : IService
        {
            public void Do(){}
        }
    }
}
