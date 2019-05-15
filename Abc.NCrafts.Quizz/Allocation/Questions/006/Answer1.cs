using System;

namespace Abc.NCrafts.Quizz.Questions._006
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