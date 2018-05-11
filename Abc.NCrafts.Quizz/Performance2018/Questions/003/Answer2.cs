using System;
using System.Linq;

namespace Abc.NCrafts.Quizz.Performance2018.Questions._003
{
    public class Answer2
    {
        private readonly string[] _strings = Enumerable.Range(0, 16 * 1024).Select(i => new string(' ', i)).ToArray();

        public int Run()
        {
            var sum = 0;

            // begin
            unchecked
            {
                foreach (var value in _strings.AsSpan())
                    sum += value.Length;
            }
            // end

            return sum;
        }
    }
}
