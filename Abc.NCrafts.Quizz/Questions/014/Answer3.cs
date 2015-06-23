namespace Abc.NCrafts.Quizz.Questions._014
{
    public class Answer3
    {
        public static void Run()
        {
            var s = "ncrafts";
            var upper = string.Empty;

            // begin
            for (var i = 0; i < s.Length; i++)
            {
                upper += char.ToUpper(s[i]);
            }
            // end

            Logger.Log(upper);
        }
    }
}
