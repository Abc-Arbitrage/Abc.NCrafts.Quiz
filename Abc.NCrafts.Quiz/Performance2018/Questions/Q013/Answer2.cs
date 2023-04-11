using System;

namespace Abc.NCrafts.Quiz.Performance2018.Questions.Q013
{
    public class Answer2
    {
        public NCrafts Run()
        {
            // begin
            var n = new NCrafts(Guid.Empty, DateTime.MinValue, 42m);
            return DoSomething(in n);
            // end
        }

        private NCrafts DoSomething(in NCrafts s) => s;

        public struct NCrafts
        {
            public readonly Guid Field1;
            public readonly DateTime Field2;
            public readonly decimal Field3;

            public NCrafts(Guid field1, DateTime field2, decimal field3)
            {
                Field1 = field1;
                Field2 = field2;
                Field3 = field3;
            }
        }
    }
}
