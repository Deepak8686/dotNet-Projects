using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibanocci_series_Recursion_
{
    public class FibonacciIterative : IFibonacciMethods
    {

        public int fib(double a)
        {
            //int sum = 0;
            int n1 = 0;
            int n2 = 1;
            int sum = 0;
            //Console.WriteLine(b);
            //Console.Write(a + " " + b + " ");

            if (a == 0)
            {
                sum = 0;
            }
            else if (a == 1)
            {
                Console.WriteLine("0\n");
            }
            else
            {
                Console.Write(n1 + "\n" + n2 + "\n");
                for (int j = 2; j < a; j++)
                {
                    sum = n1 + n2;
                    Console.WriteLine(sum);
                    n1 = n2;
                    n2 = sum;
                } 
            } 
            return sum;
        }
    }
}
