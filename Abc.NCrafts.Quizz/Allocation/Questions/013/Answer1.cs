using System;

namespace Abc.NCrafts.Quizz.Questions._013
{
    [CorrectAnswer(Difficulty = Difficulty.Hard)]
    public class Answer1
    {
        public static void Run()
        {
            // begin
            var areEqual = AreEqual("NCrafts", "ncrafts");
            // end

            Logger.Log("AreEqual: {0}", areEqual);
        }

        private static bool AreEqual(string value1, string value2)
        {
            var comparison = StringComparison.OrdinalIgnoreCase;
            return value1.Equals(value2, comparison);
        }
    }
}