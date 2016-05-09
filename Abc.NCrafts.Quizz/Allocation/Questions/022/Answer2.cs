namespace Abc.NCrafts.Quizz.Questions._022
{
    [CorrectAnswer(Difficulty = Difficulty.Easy)]
    public class Answer2
    {
        public static unsafe void Run()
        {
            // begin
            var nCrafts = new NCrafts();
            *nCrafts.Array = 42;
            // end

            Logger.Log("Value: ", *nCrafts.Array);
        }

        private struct NCrafts
        {
            public unsafe fixed int Array [3];
        }
    }
}
