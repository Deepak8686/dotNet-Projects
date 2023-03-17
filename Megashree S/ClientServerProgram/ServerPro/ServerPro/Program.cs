
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ServerPro.Interface;
using ServerPro.Repository;

namespace ServerPro
{
    public class Program
    {
       static void Main(String[] args)
        {
            IServer obj = new ServerRepo();
            obj.ServerRepos();
           
        }
    }
}


