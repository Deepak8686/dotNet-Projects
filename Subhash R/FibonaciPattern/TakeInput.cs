using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonaciPattern
{
    internal class TakeInput:InterfaceFibonaci
    {
        public string input1(string input1)
        {
            Console.WriteLine(input1);
            return Console.ReadLine();
        }
    }
}
