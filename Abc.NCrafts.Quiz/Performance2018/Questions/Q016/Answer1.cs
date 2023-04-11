namespace Abc.NCrafts.Quiz.Performance2018.Questions.Q016
{
    public class Answer1
    {
        public decimal Run()
        {
            // begin
            var n = new NCrafts();
            return DoSomething(n);
            // end
        }

        private decimal DoSomething(NCrafts s) => s.Sum + s.Sum;

        public struct NCrafts
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
