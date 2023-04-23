#pragma warning disable CS0649
namespace Abc.NCrafts.Quiz.Allocation.Level1.Q022
{
    [CorrectAnswer]
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
