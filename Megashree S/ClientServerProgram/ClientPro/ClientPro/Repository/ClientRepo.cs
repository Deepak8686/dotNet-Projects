using ClientPro.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ClientPro.Repository
{
    public class ClientRepo : IClient
    {
        public void ClientRepos()
        {
            TcpClient client = new TcpClient("localhost", 8888);

            Console.WriteLine("Client is connected with the server.");

            NetworkStream stream = client.GetStream();

            byte[] data = new byte[1024];
            int bytes = stream.Read(data, 0, data.Length);
            string message = Encoding.ASCII.GetString(data, 0, bytes);

            Console.WriteLine("Server: " + message);

            Console.Write("Enter message to send to server: ");
            string input = Console.ReadLine();

            data = Encoding.ASCII.GetBytes(input);
            stream.Write(data, 0, data.Length);

            client.Close();

            Console.WriteLine("Connection closed.");
        }
    }
}
