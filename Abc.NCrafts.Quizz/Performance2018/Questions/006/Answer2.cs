using System.Linq;
using System.Numerics;

namespace Abc.NCrafts.Quizz.Performance2018.Questions._006
{
    [CorrectAnswer(Difficulty = Difficulty.Medium)]
    public class Answer2
    {
        private readonly byte[] _buffer = Enumerable.Range(0, 16 * 1024 + 7).Select(i => unchecked((byte)i)).ToArray();

        public byte Run()
        {
            var buffer = _buffer;
            byte value = 0;

            // begin
            var i = 0;

            if (Vector.IsHardwareAccelerated)
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
    }
}
