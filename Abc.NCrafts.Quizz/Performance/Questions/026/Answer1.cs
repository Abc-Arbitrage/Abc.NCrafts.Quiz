namespace Abc.NCrafts.Quizz.Performance.Questions._026
{
    [CorrectAnswer(Difficulty = Difficulty.Hard)]
    public class Answer1
    {
        public static void Run()
        {
            // begin
            var result = GreatestCommonDivisor(1245654, 45621);
            // end
            Logger.Log("GCD: {0}", result);
        }

        private static int GreatestCommonDivisor(int a, int b)
        {
            if (b == 0)
                return a;

            return GreatestCommonDivisor(b, a % b);
        }
    }
}