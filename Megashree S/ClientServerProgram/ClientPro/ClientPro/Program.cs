using ClientPro.Interface;
using ClientPro.Repository;
using System;
using System.Net.Sockets;
using System.Text;

namespace ClientPro
{
    public class Program
    {
        static void Main(string[] args)

        {
          IClient obj = new ClientRepo();
            obj.ClientRepos();
        }
    }
}

