using System.Threading.Tasks;

namespace Abc.NCrafts.Quiz.Allocation.Questions.Q021
{
    [CorrectAnswer(Difficulty = Difficulty.Hard)]
    public class Answer1
    {
        public static void Run()
        {
            // begin
            var task = LoadValue();
            if (task.IsCompleted)
            {
                var result = task.GetAwaiter().GetResult();
                Logger.Log("Task completed, Result: {0}", result);
            }
            // end
        }

        private static Task<int> LoadValue()
        {
            return Task.FromResult(1);
        }
    }
}
