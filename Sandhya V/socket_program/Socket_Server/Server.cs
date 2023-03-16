using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Socket_Server
{
    public class Server : Iserver
    {
        public void  server()
        { 
        TcpListener serverSocket = new TcpListener(IPAddress.Parse("127.0.0.1"), 8888);
        serverSocket.Start();
            Console.WriteLine("Server started");

            // Accept clients and handle their requests
            while (true)
            {
                TcpClient clientSocket = serverSocket.AcceptTcpClient();
        Console.WriteLine("Client connected");

                NetworkStream networkStream = clientSocket.GetStream();
        byte[] buffer = new byte[1024];
        int bytesRead = networkStream.Read(buffer, 0, buffer.Length);
        string dataReceived = Encoding.ASCII.GetString(buffer, 0, bytesRead);
        Console.WriteLine("Received: " + dataReceived);
               //string output = null;
               // Console.WriteLine("The result is: "+output );
               // int input=Convert.ToInt32(Console.ReadLine());

                string dataToSend = "Hello, client!";
        byte[] bytesToSend = Encoding.ASCII.GetBytes(dataToSend);
        networkStream.Write(bytesToSend, 0, bytesToSend.Length);
                networkStream.Flush();

                clientSocket.Close();
                Console.WriteLine("Client disconnected");
            }
}
}
}
