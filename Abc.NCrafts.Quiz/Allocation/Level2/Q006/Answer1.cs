using System;

namespace Abc.NCrafts.Quiz.Allocation.Level2.Q006
{
    [CorrectAnswer]
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