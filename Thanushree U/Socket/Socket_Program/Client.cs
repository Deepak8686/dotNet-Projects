using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Socket_Program
{
    public class Client
    {
        public void get()
        {
            Socket listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            // bind socket to local endpoint
            IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Any, 1234);
            listener.Bind(localEndPoint);

            // start listening for incoming connections
            listener.Listen(10);
            Socket clientSocket = null;
            try
            {
                Console.WriteLine("Server started. Waiting for clients to connect...");
                while (true)
                {
                    // accept incoming client connection
                    clientSocket = listener.Accept();
                    Console.WriteLine("Client connected. Waiting for messages...");

                    while (true)
                    {
                        // receive message
                        byte[] buffer = new byte[1024];
                        int numBytesReceived = clientSocket.Receive(buffer);
                        string messageReceived = Encoding.ASCII.GetString(buffer, 0, numBytesReceived);
                        Console.WriteLine("Received message from client: " + messageReceived);

                        // send response
                        string response = "\nHi! I'm server. I recived your message: " + messageReceived + "\n";
                        byte[] responseBuffer = Encoding.ASCII.GetBytes(response);
                        clientSocket.Send(responseBuffer);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (clientSocket != null)
                {
                    clientSocket.Shutdown(SocketShutdown.Both);
                    clientSocket.Close();
                }
            }

        }
    }
    
}
