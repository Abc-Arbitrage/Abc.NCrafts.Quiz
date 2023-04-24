using System;

namespace Abc.NCrafts.Quiz.Allocation.Level1.Q007
{
    [CorrectAnswer]
    public class Answer2
    {
        private static string _text = "ABC123XYZ";

        public static void Run()
        {
            // begin
            var numericPart = _text.AsSpan().Slice(3, 3);
            var value = int.Parse(numericPart);
            // end
            
            Logger.Log($"Value: {value}");
        }
    }
}