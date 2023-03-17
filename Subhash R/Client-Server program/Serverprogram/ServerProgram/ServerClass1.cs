﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace Serverprogram.ServerProgram
{
    public class ServerClass1
    {
           public  void StartServer()
             {
                byte[] buffer = new byte[1024];

                //  listening socket
                Socket listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                listener.Bind(new IPEndPoint(IPAddress.Any, 1234));
                listener.Listen(1);

                Console.WriteLine("Waiting for connection...");

                // Wait for a client to connect
                Socket client = listener.Accept();

                Console.WriteLine("Client connected!");

                while (true)
                {
                    // Receive data from the client
                    int bytesReceived = client.Receive(buffer);
                    string message = Encoding.ASCII.GetString(buffer, 0, bytesReceived);

                    Console.WriteLine("Received message: " + message);

                    // Send a response back to the client
                    string response = "Message received!";
                    byte[] responseBytes = Encoding.ASCII.GetBytes(response);
                    client.Send(responseBytes);
                }


            }

    }
}
