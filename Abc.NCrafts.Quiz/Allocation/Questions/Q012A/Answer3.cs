namespace Abc.NCrafts.Quiz.Allocation.Questions.Q012A
{
    [CorrectAnswer(Difficulty = Difficulty.Medium)]
    public class Answer3
    {
        private static Service _service = new(0);

        public static void Run()
        {
            // begin
            UseService(_service with { Id = 5 });
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

        private record Service(int Id) : IService
        {
            public int GetValue() => Id;
        }
    }
}
