namespace Abc.NCrafts.Quiz.Allocation.Questions.Q012
{
    public class Answer2
    {
        public static void Run()
        {
            // begin
            UseService(new Service());
            // end
        }

        private static void UseService(object service)
        {
            ((IService)service).Do();
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
