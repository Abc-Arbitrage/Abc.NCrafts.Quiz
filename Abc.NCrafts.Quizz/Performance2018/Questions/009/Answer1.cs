using System;
using System.Runtime.CompilerServices;

namespace Abc.NCrafts.Quizz.Performance2018.Questions._009
{
    public class Answer1
    {
        public void Run()
        {
            var i = 42;
            Func<int> func = () => i;

            // begin
            var sum = 0;
            for (int j = 0; j < 10_000; j++)
            {
                sum += func();
            }
            // end
        }
    }
}
