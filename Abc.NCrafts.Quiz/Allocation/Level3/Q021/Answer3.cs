using System.Threading.Tasks;

namespace Abc.NCrafts.Quiz.Allocation.Level3.Q021
{
    public class Answer3
    {
        public static void Run()
        {
            // begin
            var task = LoadValue().AsTask();
            if (task.IsCompleted)
            {
                var result = task.Result;
                Logger.Log($"Task completed, Result: {result}");
            }
            // end
        }

        private static ValueTask<int> LoadValue()
        {
            return ValueTask.FromResult(42);
        }
    }
}
