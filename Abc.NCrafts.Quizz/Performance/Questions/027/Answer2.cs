using System;
using System.Threading;

namespace Abc.NCrafts.Quizz.Performance.Questions._027
{
    public class Answer2
    {
        private static readonly Random _random;

        static Answer2()
        {
            _random = new Random();
        }

        public static void Run()
        {
            var value = _random.Next();
            // begin
            var isValid = IsValid1(value) & IsValid2(value) & IsValid3(value);
            // end
            Logger.Log("IsValid: {0}", isValid);
        }

        private static bool IsValid1(int n)
        {
            return n < 100;
        }

        private static bool IsValid2(int n)
        {
            return n % 10 == 0;
        }

        private static bool IsValid3(int n)
        {
            Thread.Sleep(1);
            return n % 3 == 0;
        }
    }
}