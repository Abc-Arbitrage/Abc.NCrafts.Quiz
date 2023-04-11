using System.Linq;

namespace Abc.NCrafts.Quizz.Performance2018.Questions.Q014
{
    public class Answer2
    {
        private readonly int[] _buffer = Enumerable.Range(0, 16 * 1024)
                                                   .ToArray();

        public unsafe int Run()
        {
            var sum = 0;

            // begin
            fixed (int* ptrInt = _buffer)
            {
                for (var i = 0; i < _buffer.Length; ++i)
                    sum += ptrInt[i];
            }
            // end

            return sum;
        }
    }
}
