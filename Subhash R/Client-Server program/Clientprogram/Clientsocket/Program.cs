using Clientprogram.Clientsocket;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Clientprogram
{
    class Program
    {
      static void Main(string[] args)
        {
            Clientcalc client = new Clientcalc();
            client.StartClient();
        }

        
    }
}