namespace Abc.NCrafts.Quizz.Allocation.Questions.Q014
{
    [CorrectAnswer(Difficulty = Difficulty.Easy)]
    public class Answer1
    {
        public static void Run()
        {
            var s = "NewCrafts";

            // begin
            unsafe
            {
                fixed (char* p = s)
                {
                    for (var i = 0; i < s.Length; i++)
                    {
                        *(p + i) = char.ToUpper((*p));
                    }
                }
            }
            // end

            Logger.Log(s);
        }
    }
}
