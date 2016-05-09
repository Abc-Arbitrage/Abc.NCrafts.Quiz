namespace Abc.NCrafts.Quizz.Questions._012
{
    public class Answer2
    {
        public static void Run()
        {
            var service = new Service();

            // begin
            UseService(service);
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
