namespace Abc.NCrafts.Quizz.Questions._016
{
    public class Answer2
    {
        public static void Run()
        {
            // begin
            new NCrafts().GetHashCode();
            // end
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
