using System;

namespace Abc.NCrafts.Quizz.Questions._008
{
    public class Answer3
    {
        public static void Run()
        {
            // begin
            var status = (Status)64;
            var defined = Enum.IsDefined(typeof(Status), status);
            if (defined)
                Console.WriteLine("Allocation!");
            // end

            Logger.Log("Status: {0}", status);
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