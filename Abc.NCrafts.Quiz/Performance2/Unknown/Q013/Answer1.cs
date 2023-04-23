using System;

namespace Abc.NCrafts.Quiz.Performance2.Unknown.Q013
{
    [CorrectAnswer]
    public class Answer1
    {
        public Data Run()
        {
            // begin
            var n = new Data(Guid.Empty, DateTime.MinValue, 42m);
            return DoSomething(ref n);
            // end
        }

        private ref Data DoSomething(ref Data s) => ref s;

        public struct Data
        {
            public Guid Field1;
            public DateTime Field2;
            public decimal Field3;

            public Data(Guid field1, DateTime field2, decimal field3)
            {
                Field1 = field1;
                Field2 = field2;
                Field3 = field3;
            }
        }
    }
}
