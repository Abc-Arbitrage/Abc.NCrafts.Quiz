using System;

namespace Abc.NCrafts.Quizz.Questions._007
{
    public class Answer3
    {
        public static void Run()
        {
            // begin
            var i = 42;

            Execute(() => i++);
            // end
        }

        private static void Execute(Func<int> func)
        {
            func();
        }
    }
}
