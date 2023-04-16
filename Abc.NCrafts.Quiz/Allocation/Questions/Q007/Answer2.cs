using System;

namespace Abc.NCrafts.Quiz.Allocation.Questions.Q007
{
    [CorrectAnswer(Difficulty = Difficulty.Easy)]
    public class Answer2
    {
        private static string _text = "ABC123XYZ";

        public static void Run()
        {
            // begin
            var value = int.Parse(_text.AsSpan().Slice(3, 3));
            // end
            
            Logger.Log($"Value: {value}");
        }
    }
}