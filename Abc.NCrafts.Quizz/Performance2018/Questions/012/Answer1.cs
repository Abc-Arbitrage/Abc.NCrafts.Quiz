namespace Abc.NCrafts.Quizz.Performance2018.Questions._012
{
    [CorrectAnswer(Difficulty = Difficulty.Easy)]
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
