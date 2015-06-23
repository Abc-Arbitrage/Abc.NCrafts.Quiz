using System.Net.Sockets;

namespace Abc.NCrafts.Quizz.Questions._025
{
    public class Answer2
    {
        public static void Run()
        {
            var socket = SocketBuilder.GetSocket();
            var networkStream = new NetworkStream(socket);
            var buffer = new byte[0x1000];

            // begin
            var task = networkStream.ReadAsync(buffer, 0, 1);
            // end

            task.Wait();

            Logger.Log("Byte: {0}", buffer[0]);
        }
    }
}