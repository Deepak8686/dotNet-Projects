using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ServerSPAFP
{
    public class ServerAbstract : IServer
    {
        public void Serversocket()
        {
            // Create a TCP/IP socket
            Socket listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            // Bind the socket to the local endpoint and listen for incoming connections
            IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 8888);

            listener.Bind(localEndPoint);
            listener.Listen(10);

            Console.WriteLine("Waiting for a connection...");

            // Accept incoming connections
            Socket handler = listener.Accept();

            while (true)
            {
                // Receive data from the client
                byte[] bytes = new byte[1024];
                int bytesRec = handler.Receive(bytes);
                string data = Encoding.ASCII.GetString(bytes, 0, bytesRec);
                Console.WriteLine($"Received from client: {data}");

                // Get user input to send back to the client
                Console.Write("Enter a message to send back to client: ");
                string response = Console.ReadLine();

                // Send a response back to the client
                byte[] msg = Encoding.ASCII.GetBytes(response);
                handler.Send(msg);

                // Break the loop if the client has disconnected
                if (!handler.Connected) break;
            }

            // Release the socket
            handler.Shutdown(SocketShutdown.Both);
            handler.Close();
        }
    }
}

