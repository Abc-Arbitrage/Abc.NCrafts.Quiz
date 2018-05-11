using System;

namespace Abc.NCrafts.Quizz.Performance2018.Questions._002
{
    [CorrectAnswer(Difficulty = Difficulty.Easy)]
    public class Answer1
    {
        private const string _str = "Foo Bar Baz 123456";

        public int Run()
        {
            // begin
            return int.Parse(_str.AsSpan().Slice(12));
            // end
        }
    }
}
