namespace Abc.NCrafts.Quizz.Performance.Questions._011
{
    public class Answer1
    {
        public static void Run()
        {
            // begin
            var result = Factorial(1234);
            // end
            Logger.Log("Factorial: {0}", result);
        }

        private static long Factorial(long n)
        {
            if (n == 0)
                return 1;

            return n * Factorial(n - 1);
        }
    }
}