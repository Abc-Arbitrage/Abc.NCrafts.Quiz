namespace Abc.NCrafts.Quizz.Questions._016
{
    [CorrectAnswer(Difficulty = Difficulty.Medium)]
    public class Answer1
    {
        public static void Run()
        {
            // begin
            new NCrafts().GetHashCode();
            // end
        }

        public struct NCrafts
        {
            public override int GetHashCode()
            {
                return 42;
            }
        }
    }
}
