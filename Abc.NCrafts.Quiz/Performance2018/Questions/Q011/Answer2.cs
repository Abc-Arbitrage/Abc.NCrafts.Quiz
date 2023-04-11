namespace Abc.NCrafts.Quiz.Performance2018.Questions.Q011
{
    public class Answer2
    {
        public void Run()
        {
            var o = GetInstance();

            // begin
            var s = o as string;
            if (s != null)
                UseAsString(s);
            // end
        }

        private object GetInstance() => "lol";

        private void UseAsString(string s)
        {
        }
    }
}
