namespace Abc.NCrafts.Quiz.Allocation.Questions.Q023
{
    [CorrectAnswer(Difficulty = Difficulty.Medium)]
    public class Answer1
    {
        private static readonly string _s1 = "NewCrafts";
        private static readonly string _s2 = string.Empty;
        private static readonly char[] _invalidChars = { 'z' };

        public static void Run()
        {
            // begin
            var s3 = _s1 + _s2;
            var s4 = s3.Trim(_invalidChars);
            // end

            Logger.Log(s4);
        }
    }
}