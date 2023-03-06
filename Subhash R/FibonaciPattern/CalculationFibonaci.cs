using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FibonaciPattern
{
    internal class CalculationFibonaci
    {
        private readonly TakeInput _takeinput;

        public CalculationFibonaci(TakeInput takeInput) 
        {
            _takeinput = takeInput;
        }   
        public void Fab_call()
        {
            int n = int.Parse(_takeinput.input1("Enter the number to generate fibonaci"));
            Console.WriteLine("The Fibonaci series is:");
            for(int i=0; i<n; i++) 
            {
                Console.WriteLine(Fibonaci(i)+ "");
            }
        }
        private int  Fibonaci(int n)
        {
            if(n<=1)
            {
                return n;
            }
            return Fibonaci(n-1)+Fibonaci(n-2);
        }
    }
}
