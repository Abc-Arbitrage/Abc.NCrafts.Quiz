using System.Threading.Tasks;

namespace Abc.NCrafts.Quiz.Performance.Questions.Q020
{
    public class Answer1
    {
        private static int _counter;

        public static void Run()
        {
            // begin
            Parallel.For(0, 20, _ =>
            {
                for (var i = 0; i < 1_000; i++)
                {
                    lock (typeof(Answer1))
                        _counter++;
                }
            });
            // end

            Logger.Log($"Counter: {_counter}");
        }
    }
}