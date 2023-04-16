namespace Abc.NCrafts.Quiz.Allocation.Questions.Q013
{
    public class Answer2
    {
        public static void Run()
        {
            // begin
            var areEqual = AreEqual("NewCrafts", "newcrafts");
            // end

            Logger.Log($"AreEqual: {areEqual}");
        }

        private static bool AreEqual(string value1, string value2)
        {
            return value1.ToLowerInvariant().Equals(value2);
        }
    }
}