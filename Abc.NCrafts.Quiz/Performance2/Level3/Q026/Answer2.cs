namespace Abc.NCrafts.Quiz.Performance2.Level3.Q026
{
    [CorrectAnswer]
    public class Answer2
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
            while (b != 0)
            {
                var mod = a % b;
                a = b;
                b = mod;
            }
            return a;
        }
    }
}