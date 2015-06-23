using System.Net.Sockets;

namespace Abc.NCrafts.Quizz.Questions._025
{
    public class Answer1
    {
        public static void Run()
        {
            var socket = SocketBuilder.GetSocket();
            var networkStream = new NetworkStream(socket);

            // begin
            var b = networkStream.ReadByte();
            if (b == -1)
                return;
            // end

            Logger.Log("Value: {0}", b);
        }
    }
}