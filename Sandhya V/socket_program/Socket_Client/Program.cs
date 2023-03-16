using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Socket_Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Iclient clientobj = new client();
            clientobj.Client();
        }
    }
}
