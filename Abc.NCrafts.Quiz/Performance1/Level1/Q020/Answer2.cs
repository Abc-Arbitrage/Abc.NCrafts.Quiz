using System.Threading;
using System.Threading.Tasks;

namespace Abc.NCrafts.Quiz.Performance1.Level1.Q020
{
    [CorrectAnswer]
    public class Answer2
    {
        private static int _counter;

        public static void Run()
        {
            // begin
            Parallel.For(0, 20, _ =>
            {
                for (var i = 0; i < 1_000; i++)
                {
                    Interlocked.Increment(ref _counter);
                }
            });
            // end

            Logger.Log($"Counter: {_counter}");
        }
    }
}