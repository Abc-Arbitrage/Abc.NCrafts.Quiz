using System;
using System.Collections.Generic;

namespace Abc.NCrafts.Quiz.Allocation.Questions.Q015
{
    public class Answer1
    {
        public static void Run()
        {
            // begin
            var values = new List<int>(10);
            for (var i = 0; i < 10; i++)
            {
                values[i] = i;
            }
            // end

            Use(values.ToArray());
        }

        private static void Use(Span<int> span)
        {
            Logger.Log(span.Length);
        }
    }
}
