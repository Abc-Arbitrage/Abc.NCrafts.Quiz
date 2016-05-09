using System.Collections.Concurrent;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Abc.NCrafts.Quizz.Performance.Questions._021
{
    [CorrectAnswer(Difficulty = Difficulty.Hard)]
    public class Answer1
    {
        public static void Run()
        {
            var queue = new ConcurrentQueue<int>();
            var sum = 0;

            // begin
            var producer = Task.Run(() =>
            {
                foreach (var value in Enumerable.Range(0, 10000))
                {
                    queue.Enqueue(value);
                }
                queue.Enqueue(int.MaxValue);
            });

            var consumer = Task.Run(() =>
            {
                var spinWait = new SpinWait();
                while (true)
                {
                    int value;
                    if (!queue.TryDequeue(out value))
                    {
                        spinWait.SpinOnce();
                        continue;
                    }
                    if (value == int.MaxValue)
                        break;

                    sum += value;
                }
            });

            Task.WaitAll(producer, consumer);
            // end

            Logger.Log("Sum: {0}", sum);
        }
    }
}