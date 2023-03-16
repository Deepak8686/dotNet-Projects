using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Socket_Server
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Iserver server = new Server();
            server.server();
        }
    }
}
