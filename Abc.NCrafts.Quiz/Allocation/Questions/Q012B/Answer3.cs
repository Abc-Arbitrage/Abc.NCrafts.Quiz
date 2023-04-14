namespace Abc.NCrafts.Quiz.Allocation.Questions.Q012B
{
    [CorrectAnswer(Difficulty = Difficulty.Medium)]
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
            Logger.Log("Value: {0}", service.GetValue());
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
