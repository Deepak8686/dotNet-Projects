using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_series
{
    public class InputFib : InterfaceFib
    {
        public string GetUserInput(string a)
        {
            Console.Write(a);
            return Console.ReadLine();
        }
    }
}
