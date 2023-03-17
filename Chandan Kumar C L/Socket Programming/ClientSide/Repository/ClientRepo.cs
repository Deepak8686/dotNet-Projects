using ClientSide.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ClientSide.Repository
{
    internal class ClientRepo:IClient
    {
        public void ClientSocket()
        {
            Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            client.Connect(new IPEndPoint(IPAddress.Loopback, 11000));

            // Send a request to the server.
            //string request = "Request from client";
            Console.WriteLine("enter a message:");
            string message=Convert.ToString(Console.ReadLine());
            byte[] requestBytes = Encoding.ASCII.GetBytes(message);
            client.Send(requestBytes);

            // Receive the server response.
            byte[] responseBytes = new byte[1024];
            int bytesReceived = client.Receive(responseBytes);
            string response = Encoding.ASCII.GetString(responseBytes, 0, bytesReceived);
            Console.WriteLine("Received: {0}", response);

            // Close the connection.
            client.Shutdown(SocketShutdown.Both);
            client.Close();

            Console.ReadKey();
        }
    }
}
