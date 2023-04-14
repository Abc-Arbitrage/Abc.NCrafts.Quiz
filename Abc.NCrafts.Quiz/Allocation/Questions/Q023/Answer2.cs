namespace Abc.NCrafts.Quiz.Allocation.Questions.Q023
{
    public class Answer
    {
        private static readonly string _s1 = "NewCrafts";
        private static readonly char[] _invalidChars = { 's' };

        public static void Run()
        {
            // begin
            var s2 = _s1.Trim(_invalidChars);
            // end

            Logger.Log(s2);
        }
    }
}