using System;

namespace Abc.NCrafts.Quizz.Questions._015
{
    public class Answer2
    {
        public static void Run()
        {
            // begin
            Span<int> values = new int[10];
            for (var i = 0; i < 10; i++)
            {
                values[i] = i;
            }
            // end

            Use(values);
        }

        private static void Use(Span<int> span)
        {
            Logger.Log(span.Length);
        }
    }
}
