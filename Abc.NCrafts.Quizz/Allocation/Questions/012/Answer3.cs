namespace Abc.NCrafts.Quizz.Questions._012
{
    [CorrectAnswer(Difficulty = Difficulty.Easy)]
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
