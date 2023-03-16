using ServerSide.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ServerSide.Repository
{
    public class ServerRepo:IServer
    {
        public void ServerSocket()
        {
            // Create a TCP/IP socket.
            Socket listener = new Socket(IPAddress.Any.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            // Bind the socket to the local endpoint and listen for incoming connections.
            listener.Bind(new IPEndPoint(IPAddress.Any, 11000));
            listener.Listen(10);

            Console.WriteLine("Waiting for a connection...");

            while (true)
            {
                // Wait for a client connection.
                Socket client = listener.Accept();
                Console.WriteLine("Connected with {0}", client.RemoteEndPoint);

                // Handle the client request.
                byte[] bytes = new byte[1024];
                int bytesReceived = client.Receive(bytes);
                string request = Encoding.ASCII.GetString(bytes, 0, bytesReceived);
                Console.WriteLine("Received: {0}", request);

                // Send a response to the client.
                string response = "Response from the server";
                byte[] responseBytes = Encoding.ASCII.GetBytes(response);
                client.Send(responseBytes);

                // Close the client connection.
                client.Shutdown(SocketShutdown.Both);
                client.Close();
                //Console.WriteLine("Disconnected from {0}", client.RemoteEndPoint);
            }
        }
    }
}
