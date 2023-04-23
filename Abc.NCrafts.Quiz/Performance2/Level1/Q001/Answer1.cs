namespace Abc.NCrafts.Quiz.Performance2.Level1.Q001
{
    [CorrectAnswer]
    public class Answer1
    {
        private int _counter;

        public int Run()
        {
            _counter = 0;

            // begin
            var (a, b) = (GetCounter(), GetCounter());
            (b, a) = (a, b);
            return a - b;
            // end
        }

        private int GetCounter()
            => ++_counter;
    }
}
