using System.Linq;

namespace Abc.NCrafts.Quiz.Performance1.Level2.Q028
{
    public class Answer2
    {
        public static void Run()
        {
            // begin
            var primes = Enumerable.Range(0, 10_000)
                                   .Where(IsPrime)
                                   .ToList();
            // end
            Logger.Log($"PrimesCount: {primes.Count}");
        }

        private static bool IsPrime(int number)
        {
            if (number == 0 || number == 1) return false;
            if (number == 2) return true;

            var max = number / 2;
            for (var divisor = 2; divisor < max; divisor++)
            {
                if (number % divisor == 0) return false;
            }
            return true;
        }
    }
}