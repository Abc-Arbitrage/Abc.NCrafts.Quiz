using System.IO;
using System.Text;

namespace Abc.NCrafts.Quizz.Questions._021
{
    [CorrectAnswer(Difficulty = Difficulty.Medium)]
    public class Answer3
    {
        private const string _text = "Am I allocating?";

        public static void Run()
        {
            var stream = new MemoryStream(0x1000);
            var messageBytes = Encoding.ASCII.GetBytes(_text);

            // begin
            stream.Write(messageBytes, 0, messageBytes.Length);

            var bytes = stream.GetBuffer();
            for (var i = 0; i < stream.Length; i++)
            {
                bytes[i] = (byte)char.ToUpper(((char)bytes[i]));
            }
            // end

            var upperMessage 
                = Encoding.ASCII.GetString(bytes, 
                                           0, 
                                           (int)stream.Length);
            Logger.Log(upperMessage);
        }
    }
}
