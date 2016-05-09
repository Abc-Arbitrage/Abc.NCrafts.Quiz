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

        private struct NCrafts : IHashable<NCrafts>
        {
        }

        public interface IHashable<T>
        {
            int GetHashCode();
        }
    }
}
