using System;

namespace Abc.NCrafts.Quiz.Performance2.Unknown.Q001
{
    [CorrectAnswer]
    public class Answer1
    {
        private readonly DateTime _time;

        public Answer1()
        {
            _time = DateTime.Now;
        }

        public string Run()
        {
            // begin
            return $"The time is: {_time:HH:mm:ss.fff}";
            // end
        }
    }
}
