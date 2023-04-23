using System.Linq;
using System.Runtime.CompilerServices;

namespace Abc.NCrafts.Quiz.Performance2.Level3.Q005
{
    public class Answer1
    {
        private readonly int[] _buffer = Enumerable.Range(0, 16 * 1024)
                                                   .ToArray();

        public int Run()
        {
            var sum = 0;

            // begin
            ref var byteRef = ref Unsafe.As<int, byte>(ref _buffer[0]);
            var byteCount = _buffer.Length * sizeof(int);

            for (var i = 0; i < byteCount; ++i)
                sum += Unsafe.Add(ref byteRef, i);
            // end

            return sum;
        }
    }
}
