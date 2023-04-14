namespace Abc.NCrafts.Quiz.Allocation.Questions.Q010
{
    [CorrectAnswer(Difficulty = Difficulty.Medium)]
    public class Answer1
    {
        public static void Run()
        {
            // begin
            var values = GetValues();
            var sum = values.x + values.y;
            // end

            Logger.Log("Sum: {0}", sum);
        }

        private static (int x, int y) GetValues()
            => (10, 42);
    }
}