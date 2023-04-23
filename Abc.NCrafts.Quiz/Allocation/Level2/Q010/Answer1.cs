namespace Abc.NCrafts.Quiz.Allocation.Level2.Q010
{
    [CorrectAnswer]
    public class Answer1
    {
        public static void Run()
        {
            // begin
            var values = GetValues();
            var sum = values.x + values.y;
            // end

            Logger.Log($"Sum: {sum}");
        }

        private static (int x, int y) GetValues()
            => (10, 42);
    }
}