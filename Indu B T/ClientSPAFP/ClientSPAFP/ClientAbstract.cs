using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ClientSPAFP
{
    public class ClientAbstract : IClient
    {
        public void Clientsocket()
        {
            // Connect to the server
            IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
            IPEndPoint remoteEndPoint = new IPEndPoint(ipAddress, 8888);

            Socket sender = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            sender.Connect(remoteEndPoint);
            Console.WriteLine("Connected to server...");

            while (true)
            {
                // Get user input to send to the server
                Console.Write("Enter a message to send to server: ");
                string input = Console.ReadLine();

                // Send data to the server
                byte[] msg = Encoding.ASCII.GetBytes(input);
                int bytesSent = sender.Send(msg);
                Console.WriteLine($"Sent to server: {bytesSent} bytes");

                // Receive a response from the server
                byte[] bytes = new byte[1024];
                int bytesRec = sender.Receive(bytes);
                string response = Encoding.ASCII.GetString(bytes, 0, bytesRec);
                Console.WriteLine($"Received from server: {response}");

                // Break the loop if the server has disconnected
                if (!sender.Connected) break;
            }

            // Release the socket
            sender.Shutdown(SocketShutdown.Both);
            sender.Close();
        }
    }
}
