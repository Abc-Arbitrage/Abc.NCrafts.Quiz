namespace Abc.NCrafts.Quizz.Performance.Questions._026
{
    public class Answer2
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
            while (b != 0)
            {
                var tmp = b;
                b = a % b;
                a = tmp;
            }
            return a;
        }
    }
}