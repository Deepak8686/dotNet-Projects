﻿using Serverprogram.ServerProgram;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Serverprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            ServerClass1 servercode = new ServerClass1();
            servercode.StartServer();
        }
    }
}