using System.Threading.Tasks;

namespace Abc.NCrafts.Quizz.Performance2018.Questions.Q010
{
    [CorrectAnswer(Difficulty = Difficulty.Medium)]
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
