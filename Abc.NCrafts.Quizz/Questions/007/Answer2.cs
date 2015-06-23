using System;

namespace Abc.NCrafts.Quizz.Questions._007
{
    public class Answer2
    {
        public static void Run()
        {
            // begin
            var i = 42;

            if (Execute(x => ++i, i) == 42)
                throw new Exception("lol");
            // end
        }

        private static int Execute(Func<int, int> func, int i)
        {
            return func(i);
        }
    }
}
