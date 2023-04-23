namespace Abc.NCrafts.Quiz.Performance2.Level1.Q016
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

        public readonly struct Data
        {
            public readonly decimal Field1;
            public readonly decimal Field2;
            public readonly decimal Field3;
            public readonly decimal Field10;
            public readonly decimal Field20;
            public readonly decimal Field30;

            public decimal Sum => Field1 + Field2 + Field3;
        }
    }
}
