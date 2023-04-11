namespace Abc.NCrafts.Quiz.Performance2018.Questions.Q012
{
    public class Answer2
    {
        public void Run()
        {
            var o = GetInstance();

            // begin
            if (!(o is string))
                return;

            var s = (string)o;

            if (s.Length < 10)
                UseShortString(s);
            else if(s.Length >= 10)
                UseLongString(s);
            // end
        }

        private object GetInstance() => "Some long string";

        private void UseShortString(string s)
        {
        }

        private void UseLongString(string s)
        {
        }
    }
}
