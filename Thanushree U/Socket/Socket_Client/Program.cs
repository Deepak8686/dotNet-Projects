﻿using Socket_Client;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

class Program
{
    static void Main(string[] args)
    {

        Server server = new Server();
        server.get();
    }
}

