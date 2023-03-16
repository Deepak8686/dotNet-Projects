using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ServerSide.Interface;
using ServerSide.Repository;

namespace ServerSide
{
    public class Program  
    {
        static void Main(string[] args)
        {
            IServer server = new ServerRepo();
            server.ServerSocket();
        }
    }
}
