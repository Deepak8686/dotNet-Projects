using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ServerPro.Interface;

namespace ServerPro.Repository
{
   public class ServerRepo : IServer
    {
        public void ServerRepos() 
        {
            IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
            int port = 8888;

            TcpListener listener = new TcpListener(ipAddress, port);
            listener.Start();

            Console.WriteLine("Server is waiting for the connection...");

            TcpClient client = listener.AcceptTcpClient();

            Console.WriteLine("Client connected.");

            NetworkStream stream = client.GetStream();

            string message = "Welcome to the server!";
            byte[] data = Encoding.ASCII.GetBytes(message);
            stream.Write(data, 0, data.Length);

            data = new byte[1024];
            int bytes = stream.Read(data, 0, data.Length);
            message = Encoding.ASCII.GetString(data, 0, bytes);

            Console.WriteLine("Client: " + message);

            client.Close();

            Console.WriteLine("Connection closed.");
        }
    }
}
