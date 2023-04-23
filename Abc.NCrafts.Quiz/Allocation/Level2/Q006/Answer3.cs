using System;

namespace Abc.NCrafts.Quiz.Allocation.Level2.Q006
{
    public class Answer3
    {
        public static void Run()
        {
            var answer3 = new Answer3();

            // begin
            Execute(answer3.DoSomething);
            // end
        }

        private void DoSomething()
        {
        }

        private static void Execute(Action action)
        {
            action();
        }
    }
}