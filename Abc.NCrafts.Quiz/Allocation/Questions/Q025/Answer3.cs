using System.Net.Sockets;

namespace Abc.NCrafts.Quiz.Allocation.Questions.Q025
{
    [CorrectAnswer(Difficulty = Difficulty.Hard)]
    public class Answer3
    {
        public static void Run()
        {
            var socket = SocketBuilder.GetSocket();
            var networkStream = new NetworkStream(socket);
            var buffer = new byte[0x1];

            // begin
            var readByteCount = networkStream.Read(buffer, 0, 1) ;
            if (readByteCount == 0)
                return;
            // end

            Logger.Log("Byte: {0}", buffer[0]);
        }
    }
}