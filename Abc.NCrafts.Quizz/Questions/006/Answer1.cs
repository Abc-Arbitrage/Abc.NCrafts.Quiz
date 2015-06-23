using System;

namespace Abc.NCrafts.Quizz.Questions._006
{
    [CorrectAnswer(Difficulty = Difficulty.Medium)]
    public class Answer1
    {
        public static void Run()
        {
            var action = (Action)(() => { });

            // begin
            Execute(action);
            // end
        }

        private static void Execute(Action action)
        {
            action();
        }
    }
}