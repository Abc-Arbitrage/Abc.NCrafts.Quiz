namespace Abc.NCrafts.Quiz.Allocation.Level2.Q016
{
    [CorrectAnswer]
    public class Answer1
    {
        public static void Run()
        {
            // begin
            var code = new NCrafts().GetHashCode();
            // end
            
            Logger.Log(code);
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
