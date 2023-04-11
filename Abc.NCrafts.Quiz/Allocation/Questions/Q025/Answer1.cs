using System.Net.Sockets;

namespace Abc.NCrafts.Quiz.Allocation.Questions.Q025
{
    public class Answer1
    {
        public static void Run()
        {
            var socket = SocketBuilder.GetSocket();
            var networkStream = new NetworkStream(socket);

            // begin
            var b = networkStream.ReadByte(); // TODO CAO (it no longer allocates)
            if (b == -1)
                return;
            // end

            Logger.Log("Value: {0}", b);
        }
    }
}