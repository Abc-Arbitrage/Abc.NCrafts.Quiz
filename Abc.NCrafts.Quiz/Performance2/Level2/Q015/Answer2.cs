﻿namespace Abc.NCrafts.Quiz.Performance2.Level2.Q015
{
    [CorrectAnswer]
    public class Answer2
    {
        public decimal Run()
        {
            // begin
            var n = new NCrafts();
            return DoSomething(n);
            // end
        }

        private decimal DoSomething(in NCrafts s) => s.Sum;

        public struct NCrafts
        {
            public decimal Field1;
            public decimal Field2;
            public decimal Field3;

            public decimal Sum => Field1 + Field2 + Field3;
        }
    }
}
