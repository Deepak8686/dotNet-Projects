using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientSPAFP
{
    public class Program
    {
        static void Main(string[] args)
        {
            IClient socket = new ClientAbstract();
            socket.Clientsocket();
        }
    }
}
