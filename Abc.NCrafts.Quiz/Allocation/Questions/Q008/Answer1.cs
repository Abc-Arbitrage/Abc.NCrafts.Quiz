using System;

namespace Abc.NCrafts.Quiz.Allocation.Questions.Q008
{
    // good
    public class Answer1
    {
        public static void Run()
        {
            // begin
            var status = Status.S2 | Status.S3;
            var hasFlag = ((Enum)status).HasFlag(Status.S1);
            if (hasFlag)
                Console.WriteLine("Allocation!");
            // end
        }

        [Flags]
        private enum Status
        {
            None = 0,
            S1 = 1,
            S2 = 2,
            S3 = 4,
        }
    }
}