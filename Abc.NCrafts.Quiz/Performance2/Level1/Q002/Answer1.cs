using System;

namespace Abc.NCrafts.Quiz.Performance2.Level1.Q002
{
    [CorrectAnswer]
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
