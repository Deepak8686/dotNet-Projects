using Itterativeapproach.MainFactory.RecursiveFactory.InterfaceRecursive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Itterativeapproach.MainFactory.RecursiveFactory.RECalculation
{
    public class RecusiveFibonacci: RecursiveInterface1
    {
        private readonly int _fibonaccirecursive;

        public RecusiveFibonacci(int fibonaccirecursive)
        {
            _fibonaccirecursive=fibonaccirecursive;
        }
        public void Recursivecal()
        {

            Console.WriteLine("THE fibonaci series is:\n");
            for (int i = 0; i<_fibonaccirecursive; i++)
            {
                Console.WriteLine(fibonaccirecursive(i) + "");

            }
        }
            private int fibonaccirecursive(int n)
            {
                if (n<=1)
                {
                    return n;
                }
                return fibonaccirecursive(n-1)+ fibonaccirecursive(n-2);

            }
        }
}
