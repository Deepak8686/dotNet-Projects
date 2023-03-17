using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Socket_Client
{
    public class Server
    {
        public void get()
        {
            Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                int port = 1234;
                IPAddress serverIP = IPAddress.Parse("127.0.0.1");
                IPEndPoint serverEndPoint = new IPEndPoint(serverIP, port);
                clientSocket.Connect(serverEndPoint);

                Console.WriteLine("Connected to server...\n");
            }
            catch (Exception)
            {
                Console.WriteLine("No connection could be made because the server machine is inactive");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
                Environment.Exit(0);
            }

            while (true)
            {
                Console.Write("\nEnter message you wish to send to server or Type 'quit' to exit.\n ");
                string messageToSend = Console.ReadLine();

                if (messageToSend.ToLower() == "quit")
                {
                    break;
                }
                //send to server
                byte[] buffer = Encoding.ASCII.GetBytes(messageToSend);
                clientSocket.Send(buffer);

                // receive from server
                byte[] responseBuffer = new byte[1024];
                int numBytesReceived = clientSocket.Receive(responseBuffer);
                string response = Encoding.ASCII.GetString(responseBuffer, 0, numBytesReceived);
                Console.WriteLine("\nResponse from server:\n " + response);
            }
            clientSocket.Shutdown(SocketShutdown.Both);
            clientSocket.Close();

        }
    }
}
