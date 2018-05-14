namespace Abc.NCrafts.Quizz.Performance2018.Questions._009
{
    [CorrectAnswer(Difficulty = Difficulty.Medium)]
    public class Answer2
    {
        public void Run()
        {
            var i = 42;
            int Func() => i;

            // begin
            var sum = 0;
            for (int j = 0; j < 10_000; j++)
            {
                sum += Func();
            }
            // end
        }
    }
}
