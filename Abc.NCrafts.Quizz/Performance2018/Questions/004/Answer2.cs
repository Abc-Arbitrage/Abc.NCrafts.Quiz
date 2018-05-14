using System.Linq;

namespace Abc.NCrafts.Quizz.Performance2018.Questions._004
{
    public class Answer2
    {
        private readonly int[] _buffer = Enumerable.Range(0, 16 * 1024)
                                                   .ToArray();

        public unsafe int Run()
        {
            var sum = 0;

            // begin
            fixed (int* ptrInt = &_buffer[0])
            {
                var ptrByte = (byte*)ptrInt;
                var byteCount = _buffer.Length * sizeof(int);

                for (var i = 0; i < byteCount; ++i)
                    sum += ptrByte[i];
            }
            // end

            return sum;
        }
    }
}
