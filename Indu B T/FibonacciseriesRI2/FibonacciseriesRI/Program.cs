using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciseriesRI
{
    public class Program
    {
        static void Main(string[] args)
        {
            IRecursiveIterative fibos = new Fibonacciseries();
            fibos.Fibo();
        }
    }
}
