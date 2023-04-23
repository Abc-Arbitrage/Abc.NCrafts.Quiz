using System;

namespace Abc.NCrafts.Quiz.Performance2.Unknown.Q013
{
    public class Answer2
    {
        public Data Run()
        {
            // begin
            var n = new Data(Guid.Empty, DateTime.MinValue, 42m);
            return DoSomething(in n);
            // end
        }

        private Data DoSomething(in Data s) => s;

        public struct Data
        {
            public readonly Guid Field1;
            public readonly DateTime Field2;
            public readonly decimal Field3;

            public Data(Guid field1, DateTime field2, decimal field3)
            {
                Field1 = field1;
                Field2 = field2;
                Field3 = field3;
            }
        }
    }
}
