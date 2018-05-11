using System.Linq;

namespace Abc.NCrafts.Quizz.Performance2018.Questions._006
{
    public class Answer1
    {
        private readonly byte[] _buffer = Enumerable.Range(0, 16 * 1024 + 7).Select(i => unchecked((byte)i)).ToArray();

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
    }
}
