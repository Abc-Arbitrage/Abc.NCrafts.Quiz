using System;

namespace Abc.NCrafts.Quiz.Allocation.Questions.Q022
{
    public class Answer1
    {
        public static void Run()
        {
            // begin
            var data = new Data();
            data.Ids[0] = 999;
            // end

            Logger.Log($"Value: {data.Ids[0]}");
        }

        private ref struct Data
        {
            public Span<int> Ids;

            public Data()
            {
                Ids = new int[3];
            }
        }
    }
}
