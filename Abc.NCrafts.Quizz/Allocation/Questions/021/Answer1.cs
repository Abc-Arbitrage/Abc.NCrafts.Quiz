using System.IO;
using System.Text;

namespace Abc.NCrafts.Quizz.Questions._021
{
    public class Answer1
    {
        private const string _text = "Am I allocating?";

        public static void Run()
        {
            var stream = new MemoryStream(0x1000);
            var messageBytes = Encoding.ASCII.GetBytes(_text);

            // begin
            stream.Write(messageBytes, 0, messageBytes.Length);

            var bytes = stream.ToArray();
            for (var i = 0; i < bytes.Length; i++)
            {
                bytes[i] = (byte)char.ToUpper(((char)bytes[i]));
            }
            // end

            var upperMessage = Encoding.ASCII.GetString(bytes);
            Logger.Log(upperMessage);
        }
    }
}
