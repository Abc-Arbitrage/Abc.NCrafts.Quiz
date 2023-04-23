using System.Threading.Tasks;

namespace Abc.NCrafts.Quiz.Performance2.Level2.Q010
{
    [CorrectAnswer]
    public class Answer1
    {
        public async void Run()
        {
            var sum = 0L;

            // begin
            for (int i = 0; i < 10_000; i++)
            {
                sum += await DoSomething();
            }
            // end
        }

        private Task<int> DoSomething() => Task.FromResult(42);
    }
}
