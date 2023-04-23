﻿namespace Abc.NCrafts.Quiz.Performance2.Level1.Q016
{
    public class Answer1
    {
        public decimal Run()
        {
            // begin
            var n = new Data();
            return DoSomething(n);
            // end
        }

        private decimal DoSomething(Data s) => s.Sum + s.Sum;

        public struct Data
        {
            public decimal Field1;
            public decimal Field2;
            public decimal Field3;
            public decimal Field10;
            public decimal Field20;
            public decimal Field30;

            public decimal Sum => Field1 + Field2 + Field3;
        }
    }
}
