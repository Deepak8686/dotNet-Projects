using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Socket_Client
{
    public class client : Iclient
    {
       public void Client()
        {
            // Set up the client socket
            TcpClient clientSocket = new TcpClient("127.0.0.1", 8888);
            Console.WriteLine("Connected to server");

            NetworkStream networkStream = clientSocket.GetStream();

            //string dataToSend = "Hello, server!";
            Console.WriteLine("input messaage:");
            string dataToSend = Convert.ToString(Console.ReadLine());
           byte[] bytesToSend = Encoding.ASCII.GetBytes(dataToSend);
            networkStream.Write(bytesToSend, 0, bytesToSend.Length);
            networkStream.Flush();

            //Console.WriteLine("Enter a number:");
            //int input = Convert.ToInt32(Console.ReadLine());
           //byte[] bytesToSend1 = Encoding.ASCII.GetBytes(input);
            //networkStream.Write(bytesToSend1, 0, bytesToSend1.Length);
            //networkStream.Flush();

            byte[] buffer = new byte[1024];
            int bytesRead = networkStream.Read(buffer, 0, buffer.Length);
            string dataReceived = Encoding.ASCII.GetString(buffer, 0, bytesRead);
            Console.WriteLine("Received: " + dataReceived);

            clientSocket.Close();
            Console.WriteLine("Disconnected from server");
            Console.ReadKey();
        }
    }
}
