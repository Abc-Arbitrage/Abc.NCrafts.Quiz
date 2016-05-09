using System.Threading;
using System.Threading.Tasks;

namespace Abc.NCrafts.Quizz.Performance.Questions._020
{
    [CorrectAnswer(Difficulty = Difficulty.Easy)]
    public class Answer2
    {
        private static int _counter;

        public static void Run()
        {
            // begin
            var tasks = new Task[20];
            for (var i = 0; i < tasks.Length; i++)
            {
                tasks[i] = Task.Run(() =>
                {
                    for (var j = 0; j < 10 * 1000 * 1000; j++)
                    {
                        Interlocked.Increment(ref _counter);
                    }
                });
            }
            Task.WaitAll(tasks);
            // end

            Logger.Log($"Counter: {_counter}");
        }
    }
}
