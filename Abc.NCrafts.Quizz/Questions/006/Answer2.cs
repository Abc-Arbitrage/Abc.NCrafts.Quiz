using System;

namespace Abc.NCrafts.Quizz.Questions._006
{
    public class Answer2
    {
        public static void Run()
        {
            // begin
            Execute(DoSomething);
            // end
        }

        private static void DoSomething()
        {    
        }

        private static void Execute(Action action)
        {
            action();
        }
    }
}