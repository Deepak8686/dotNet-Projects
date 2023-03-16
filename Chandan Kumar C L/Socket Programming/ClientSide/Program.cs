using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ClientSide.Interface;
using ClientSide.Repository;

namespace ClientSide
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IClient client = new ClientRepo();
            client.ClientSocket();
        }
    }
}
