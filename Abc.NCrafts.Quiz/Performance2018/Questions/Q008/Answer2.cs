using System;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;

namespace Abc.NCrafts.Quiz.Performance2018.Questions.Q008
{
    public class Answer2
    {
        private readonly byte[] _buffer = GetBytes();

        public unsafe byte Run()
        {
            var buffer = _buffer;
            byte value = 0;

            // begin
            var i = 0;

            if (Avx2.IsSupported) // assume is true
            {
                const int vectorSize = 256 / 8;
                
                var tmp = Vector256<byte>.Zero;

                fixed (byte* pBuf = &buffer[0])
                {
                    var n = buffer.Length / vectorSize * vectorSize;
                    for (; i < n; i += vectorSize)
                        tmp = Avx2.Xor(tmp, Avx.LoadAlignedVector256(pBuf + i));
                }

                var tmpResult = stackalloc byte[vectorSize];
                Avx.Store(tmpResult, tmp);

                for (var j = 0; j < vectorSize; ++j)
                    value ^= tmpResult[j];
            }

            for (; i < buffer.Length; i++)
                value ^= buffer[i];
            // end

            return value;
        }

        private static byte[] GetBytes()
        {
            var bytes = new byte[16 * 1024 + 7];
            new Random(42).NextBytes(bytes);
            return bytes;
        }
    }
}
