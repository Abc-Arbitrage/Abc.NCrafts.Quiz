namespace Abc.NCrafts.Quiz.Allocation.Questions.Q023
{
    public class Answer3
    {
        private static readonly string _s1 = "NewCrafts";

        public static void Run()
        {
            // begin
            var s2 = _s1.Trim().ToString();
            var s3 = s2[1..];
            // end

            Logger.Log(s3);
        }
    }
}