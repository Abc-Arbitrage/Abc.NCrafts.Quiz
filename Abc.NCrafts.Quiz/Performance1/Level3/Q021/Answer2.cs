using System.Collections.Concurrent;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Abc.NCrafts.Quiz.Performance1.Level3.Q021
{
    public class Answer2
    {
        public static void Run()
        {
            var stack = new ConcurrentStack<int>();

            // begin
            var producer = Task.Run(() =>
            {
                foreach (var value in Enumerable.Range(1, 10_000))
                {
                    stack.Push(value);
                }
            });

            var consumer = Task.Run(() =>
            {
                var spinWait = new SpinWait();
                var value = 0;
                while (value != 10_000)
                {
                    if (!stack.TryPop(out value))
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