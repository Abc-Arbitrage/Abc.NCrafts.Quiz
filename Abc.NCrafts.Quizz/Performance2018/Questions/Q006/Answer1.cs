using System;

namespace Abc.NCrafts.Quizz.Performance2018.Questions.Q006
{
    public class Answer1
    {
        private readonly byte[] _buffer = GetBytes();

        public byte Run()
        {
            var buffer = _buffer;
            byte value = 0;

            // begin
            foreach (var i in buffer)
                value ^= i;
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
