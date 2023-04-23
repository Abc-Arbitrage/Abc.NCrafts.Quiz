using System;

namespace Abc.NCrafts.Quiz.Allocation.Level1.Q014
{
    [CorrectAnswer]
    public class Answer1
    {
        public static void Run()
        {
            var s = "NewCrafts";

            // begin
            Span<char> upper = stackalloc char[s.Length];
            for (var index = 0; index < s.Length; index++)
            {
                upper[index] = char.ToUpper(s[index]);
            }
            // end

            Logger.Log(upper);
        }
    }
}
