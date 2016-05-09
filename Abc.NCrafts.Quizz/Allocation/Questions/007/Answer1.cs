using System;

namespace Abc.NCrafts.Quizz.Questions._007
{
    [CorrectAnswer(Difficulty = Difficulty.Hard)]
    public class Answer1
    {
        public static void Run()
        {
            var a = 41;
            Execute(x => ++x, a);

            // begin
            var b = 42;

            if (Execute(x => ++x, b) == 42)
                throw new Exception("lol");
            // end
        }

        private static int Execute(Func<int, int> func, int i)
        {  
            return func(i); 
        }
    }
}
