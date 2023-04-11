namespace Abc.NCrafts.Quizz.Allocation.Questions.Q016
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
