#pragma warning disable CS0649
namespace Abc.NCrafts.Quiz.Allocation.Questions.Q022
{
    [CorrectAnswer(Difficulty = Difficulty.Easy)]
    public class Answer2
    {
        public static unsafe void Run()
        {
            // begin
            var data = new Data();
            data.Ids[0] = 999;
            // end

            Logger.Log($"Value: {data.Ids[0]}");
        }

        private unsafe struct Data
        {
            public fixed int Ids[3];
        }
    }
}
