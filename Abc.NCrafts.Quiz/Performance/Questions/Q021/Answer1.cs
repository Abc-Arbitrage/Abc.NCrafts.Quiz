using System.Collections.Concurrent;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Abc.NCrafts.Quiz.Performance.Questions.Q021
{
    [CorrectAnswer(Difficulty = Difficulty.Hard)]
    public class Answer1
    {
        public static void Run()
        {
            var queue = new ConcurrentQueue<int>();

            // begin
            var producer = Task.Run(() =>
            {
                foreach (var value in Enumerable.Range(1, 10_000))
                {
                    queue.Enqueue(value);
                }
            });

            var consumer = Task.Run(() =>
            {
                var spinWait = new SpinWait();
                var value = 0;
                while (value != 10_000)
                {
                    if (!queue.TryDequeue(out value))
                    {
                        spinWait.SpinOnce();
                        continue;
                    }
                    Logger.Log($"Value: {value}");
                }
            });

            Task.WaitAll(producer, consumer);
            // end
        }
    }
}