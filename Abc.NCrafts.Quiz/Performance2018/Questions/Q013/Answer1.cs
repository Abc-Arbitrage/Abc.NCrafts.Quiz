using System;

namespace Abc.NCrafts.Quiz.Performance2018.Questions.Q013
{
    [CorrectAnswer(Difficulty = Difficulty.Easy)]
    public class Answer1
    {
        public NCrafts Run()
        {
            // begin
            var n = new NCrafts(Guid.Empty, DateTime.MinValue, 42m);
            return DoSomething(ref n);
            // end
        }

        private ref NCrafts DoSomething(ref NCrafts s) => ref s;

        public struct NCrafts
        {
            public Guid Field1;
            public DateTime Field2;
            public decimal Field3;

            public NCrafts(Guid field1, DateTime field2, decimal field3)
            {
                Field1 = field1;
                Field2 = field2;
                Field3 = field3;
            }
        }
    }
}
