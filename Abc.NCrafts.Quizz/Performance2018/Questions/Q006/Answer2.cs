using System;
using System.Numerics;

namespace Abc.NCrafts.Quizz.Performance2018.Questions.Q006
{
    [CorrectAnswer(Difficulty = Difficulty.Medium)]
    public class Answer2
    {
        private readonly byte[] _buffer = GetBytes();

        public byte Run()
        {
            var buffer = _buffer;
            byte value = 0;

            // begin
            var i = 0;

            if (Vector.IsHardwareAccelerated) // assume is true
            {
                var tmp = Vector<byte>.Zero;

                var n = buffer.Length / Vector<byte>.Count * Vector<byte>.Count;
                for (; i < n; i += Vector<byte>.Count)
                    tmp ^= new Vector<byte>(buffer, i);

                for (var j = 0; j < Vector<byte>.Count; ++j)
                    value ^= tmp[j];
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
