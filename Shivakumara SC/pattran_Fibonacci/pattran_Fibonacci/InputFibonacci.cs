using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattran_Fibonacci
{
    public class InputFibonacci : IFibonacci
    {
        public string Getinput(string input)
        {
            Console.WriteLine(input);
            return Console.ReadLine();
        }
    }
}
