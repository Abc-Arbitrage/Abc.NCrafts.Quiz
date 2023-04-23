namespace Abc.NCrafts.Quiz.Allocation.Level2.Q016
{
    [CorrectAnswer]
    public class Answer1
    {
        public static void Run()
        {
            // begin
            var code = new Key().GetHashCode();
            // end
            
            Logger.Log(code);
        }

        public struct Key
        {
            public override int GetHashCode()
            {
                return 42;
            }
        }
    }
}
