namespace Abc.NCrafts.Quiz.Performance2.Unknown.Q015
{
    [CorrectAnswer]
    public class Answer2
    {
        public decimal Run()
        {
            // begin
            var n = new Data();
            return DoSomething(n);
            // end
        }

        private decimal DoSomething(in Data s) => s.Sum;

        public struct Data
        {
            public decimal Field1;
            public decimal Field2;
            public decimal Field3;

            public decimal Sum => Field1 + Field2 + Field3;
        }
    }
}
