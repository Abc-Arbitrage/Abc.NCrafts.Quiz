namespace Abc.NCrafts.Quizz.Questions._015
{
    [CorrectAnswer(Difficulty = Difficulty.Easy)]
    public class Answer3
    {
        public static void Run()
        {
            unsafe
            {
                // begin
                var values = stackalloc int[10];
                for (var i = 0; i < 10; i++)
                {
                    values[i] = i;
                }
                // end
            }
        }
    }
}
