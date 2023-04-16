namespace Abc.NCrafts.Quiz.Performance.Questions.Q011
{
    [CorrectAnswer(Difficulty = Difficulty.Medium)]
    public class Answer2
    {
        public static void Run()
        {
            // begin
            var result = Factorial(1234);
            // end
            Logger.Log($"Factorial: {result}");
        }

        private static long Factorial(long n)
        {
            return Factorial(n, 1);
        }

        private static long Factorial(long n, long accumulator)
        {
            if (n == 0)
                return accumulator;

            return Factorial(n - 1, n * accumulator);
        }
    }
}