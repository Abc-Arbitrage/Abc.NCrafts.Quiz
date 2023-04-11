using System.Threading.Tasks;

namespace Abc.NCrafts.Quiz.Performance2018.Questions.Q010
{
    public class Answer2
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

        private ValueTask<int> DoSomething() => new ValueTask<int>(42);
    }
}
