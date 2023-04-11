using System;

namespace Abc.NCrafts.Quiz.Allocation.Questions.Q06
{
    [CorrectAnswer(Difficulty = Difficulty.Medium)]
    public class Answer1
    {
        public static void Run()
        {
            var action = (Action)delegate { };

            // begin
            Execute(action);
            // end
        }

        private static void Execute(object action)
        {
            ((Action)action)();
        }
    }
}