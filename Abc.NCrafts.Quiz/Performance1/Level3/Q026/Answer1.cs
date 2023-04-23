namespace Abc.NCrafts.Quiz.Performance1.Level3.Q026
{
    [CorrectAnswer]
    public class Answer1
    {
        public static void Run()
        {
            // begin
            var result = GreatestCommonDivisor(1245654, 45621);
            // end
            Logger.Log($"GCD: {result}");
        }

        private static int GreatestCommonDivisor(int a, int b)
        {
            if (b == 0)
                return a;

            return GreatestCommonDivisor(b, a % b);
        }
    }
}