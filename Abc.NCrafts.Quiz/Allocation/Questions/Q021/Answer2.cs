using System.Threading.Tasks;

namespace Abc.NCrafts.Quiz.Allocation.Questions.Q021
{
    public class Answer2
    {
        public static void Run()
        {
            // begin
            var task = LoadValue();
            if (task.IsCompleted)
            {
                var result = task.Result;
                Logger.Log($"Task completed, Result: {result}");
            }
            // end
        }

        private static Task<int> LoadValue()
        {
            return Task.FromResult(42);
        }
    }
}
