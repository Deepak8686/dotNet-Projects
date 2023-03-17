using Client_Side.ClientInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Client_Side.ClientAbstract
{
    internal class ClientSideClass : IClientInterface
    {
        public void StartClient()
        {
            
                byte[] buffer = new byte[1024];

                // Set up the socket and connect to the server
                Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                client.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234));

                Console.WriteLine("Connected to server!");

                while (true)
                {
                    // Get input from the user
                    Console.Write("Send a message to Server: ");
                    string input = Console.ReadLine();

                    // Send the message to the server
                    byte[] inputBytes = Encoding.ASCII.GetBytes(input);
                    client.Send(inputBytes);

                    // Receive a response from the server
                    int bytesReceived = client.Receive(buffer);
                    string message = Encoding.ASCII.GetString(buffer, 0, bytesReceived);

                    Console.WriteLine("Response: " + message);
                }
            }
        }
    }
