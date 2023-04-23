namespace Abc.NCrafts.Quiz.Performance2.Level1.Q012
{
    [CorrectAnswer]
    public class Answer1
    {
        public void Run()
        {
            var o = GetInstance();
            // begin
            switch (o)
            {
                case string s when s.Length < 10:
                    UseShortString(s);
                    break;
                case string s when s.Length >= 10:
                    UseLongString(s);
                    break;
            }

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
