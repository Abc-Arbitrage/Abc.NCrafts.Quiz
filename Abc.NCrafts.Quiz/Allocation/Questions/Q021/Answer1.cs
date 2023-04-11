using System.IO;
using System.Text;

namespace Abc.NCrafts.Quiz.Allocation.Questions.Q021
{
    public class Answer1
    {
        private const string _text = "Am I allocating?";

        public static void Run()
        {
            var stream = new MemoryStream(1000);
            var messageBytes = Encoding.ASCII.GetBytes(_text);

            // begin
            stream.Write(messageBytes, 0, messageBytes.Length);

            var bytes = stream.ToArray();
            for (var i = 0; i < stream.Length; i++)
            {
                bytes[i] = (byte)char.ToUpper((char)bytes[i]);
            }
            // end

            Logger.LogAscii(bytes, stream.Length);
        }
    }
}
