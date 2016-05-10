using System.Collections.Concurrent;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Abc.NCrafts.Quizz.Performance.Questions._021
{
    public class Answer2
    {
        public static void Run()
        {
            var queue = new ConcurrentStack<int>();

            // begin
            var producer = Task.Run(() =>
            {
                foreach (var value in Enumerable.Range(1, 10000))
                {
                    queue.Push(value);
                }
            });

            var consumer = Task.Run(() =>
            {
                var spinWait = new SpinWait();
                var value = 0;
                while (value != 10000)
                {
                    if (!queue.TryPop(out value))
                    {
                        spinWait.SpinOnce();
                        continue;
                    }
                    Logger.Log("Value: {0}", value);
                }
            });

            Task.WaitAll(producer, consumer);
            // end
        }
    }
}