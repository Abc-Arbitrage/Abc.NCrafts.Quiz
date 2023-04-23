using System;

namespace Abc.NCrafts.Quiz.Performance2.Unknown.Q001
{
    [CorrectAnswer]
    public class Answer2
    {
        private readonly DateTime _time;

        public Answer2()
        {
            _time = DateTime.Now;
        }

        public string Run()
        {
            // begin
            return string.Format("The time is: {0:HH:mm:ss.fff}", _time);
            // end
        }
    }
}
