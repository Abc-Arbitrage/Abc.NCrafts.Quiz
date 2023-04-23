namespace Abc.NCrafts.Quiz.Allocation.Level2.Q016
{
    public class Answer2
    {
        public static void Run()
        {
            // begin
            var code = new NCrafts().GetHashCode();
            // end
            
            Logger.Log(code);
        }

        public struct NCrafts : IHashable
        {
            int IHashable.GetHashCode()
            {
                return 42;
            }
        }

        public interface IHashable
        {
            int GetHashCode();
        }
    }
}
