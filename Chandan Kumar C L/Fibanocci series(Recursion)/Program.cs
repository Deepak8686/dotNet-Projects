using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibanocci_series_Recursion_
{
    public class Program
    {

       
        static void Main(string[] args)
        {
            IFibonacci obj = new FibonacciInputs();
            obj.Inputs();
            obj.FromStart();


        }
    }
}
