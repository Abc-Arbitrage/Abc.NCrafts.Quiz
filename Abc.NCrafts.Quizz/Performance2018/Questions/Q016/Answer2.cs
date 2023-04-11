namespace Abc.NCrafts.Quizz.Performance2018.Questions.Q016
{
    [CorrectAnswer(Difficulty = Difficulty.Easy)]
    public class Answer2
    {
        public decimal Run()
        {
            // begin
            var n = new NCrafts();
            return DoSomething(in n);
            // end
        }

        private decimal DoSomething(in NCrafts s) => s.Sum + s.Sum;

        public readonly struct NCrafts
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
