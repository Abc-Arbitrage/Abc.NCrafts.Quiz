namespace Abc.NCrafts.Quiz.Performance2.Level2.Q009
{
    [CorrectAnswer]
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
