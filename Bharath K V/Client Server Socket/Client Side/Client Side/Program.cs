using Client_Side.ClientAbstract;
using Client_Side.ClientInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_Side
{
     class Program
    {
        static void Main(string[] args)
        {
            IClientInterface client = new ClientSideClass();
            client.StartClient();
        }
    }
}
