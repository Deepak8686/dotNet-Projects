using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerSPAFP
{
    public class Program
    {
        static void Main(string[] args)
        {
            IServer socket = new ServerAbstract();
            socket.Serversocket();
        }
    }
}
