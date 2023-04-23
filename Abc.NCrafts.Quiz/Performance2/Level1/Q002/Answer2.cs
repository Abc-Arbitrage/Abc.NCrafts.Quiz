namespace Abc.NCrafts.Quiz.Performance2.Level1.Q002
{
    public class Answer2
    {
        private const string _str = "Foo Bar Baz 123456";

        public int Run()
        {
            // begin
            return int.Parse(_str.Substring(12));
            // end
        }
    }
}
