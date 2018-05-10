namespace Abc.NCrafts.Quizz.Performance2018.Questions._002
{
    public class Answer2
    {
        private const string _str = "Foo Bar Baz 123456";

        public void Run()
        {
            // begin
            var result = int.Parse(_str.Substring(12));
            // end

            Logger.Log(result);
        }
    }
}
