namespace Abc.NCrafts.Quizz.Questions._023
{
    public class Answer3
    {
        private static readonly string _s1 = "Ncrafts";

        public static void Run()
        {
            // begin
            var s2 = _s1.Trim().ToString();
            var s3 = s2.Substring(1);
            // end

            Logger.Log(s3);
        }
    }
}