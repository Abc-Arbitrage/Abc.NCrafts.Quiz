namespace Abc.NCrafts.Quiz.Performance2.Level2.Q015
{
    [CorrectAnswer]
    public class Answer1
    {
        public decimal Run()
        {
            // begin
            var n = new Data();
            return DoSomething(n);
            // end
        }

        private decimal DoSomething(Data s) => s.Sum;

        public struct Data
        {
            public decimal Field1;
            public decimal Field2;
            public decimal Field3;

            public decimal Sum => Field1 + Field2 + Field3;
        }
    }
}
