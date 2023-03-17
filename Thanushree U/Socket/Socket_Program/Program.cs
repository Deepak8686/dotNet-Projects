using Socket_Program;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Client client= new Client();
        client.get();
    }
}

