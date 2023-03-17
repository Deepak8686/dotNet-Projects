using RecItrFibonacci.RecItrInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RecItrFibonacci.RecItrClass
{
     class RecursiveIterativeClass : RecursiveIterativeInterface
    {
        private readonly double _RecItrInput;
        public RecursiveIterativeClass(double RecItrInput)
        {
            _RecItrInput = RecItrInput;
        }
        public void RecursiveFibonacci()
        {
            for (int i = 0; i < _RecItrInput; i++)
            {
                Console.Write(RecFibonacci(i) + " ");
            }
        }
        private int RecFibonacci(int numb)
        {
            if (numb <= 1)
            {
                return numb;
            }
            return RecFibonacci(numb - 1) + RecFibonacci(numb - 2);
        }
        public void IterativeFibonacci()
        {
            int num1 = 0, num2 = 1;
            int i=0;
            while(i < _RecItrInput)
            {
                Console.Write(num1 + " ");
                int temp = num1;
                num1 = num2;
                num2 = temp + num1;
                i++;
            }
        }
    }
}