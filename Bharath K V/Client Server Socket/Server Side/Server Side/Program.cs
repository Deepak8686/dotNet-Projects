using Server_Side.ServerAbstract;
using Server_Side.ServerInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Side
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IServerInterface server = new ServerSideClass();
            server.ServerSocket();
        }
    }
}
