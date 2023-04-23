using System;

namespace Abc.NCrafts.Quiz.Allocation.Level1.Q001
{
    [CorrectAnswer]
    public class Answer2
    {
        public static void Run()
        {
            // begin
            var i = 42;
            Nullable<double> nullable = i;
            // end
            
            Logger.Log($"Value: {nullable}");
        }
    }
}
