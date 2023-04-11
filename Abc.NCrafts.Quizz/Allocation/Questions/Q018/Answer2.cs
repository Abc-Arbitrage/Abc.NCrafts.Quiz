using System.Collections.Generic;

namespace Abc.NCrafts.Quizz.Allocation.Questions.Q018
{
    public class Answer2
    {
        public static void Run()
        {
            GetEmptySequence<int>();

            // begin
            GetEmptySequence<int>();
            // end
        }

        private static IEnumerable<T> GetEmptySequence<T>()
        {
            yield break;
        }
    }
}
