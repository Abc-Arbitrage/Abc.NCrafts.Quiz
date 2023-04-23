using System;

namespace Abc.NCrafts.Quiz.Performance2.Level2.Q009
{
    public class Answer1
    {
        public void Run()
        {
            var i = 42;
            var func = () => i;

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
