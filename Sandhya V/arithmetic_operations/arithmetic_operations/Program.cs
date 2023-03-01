using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arithmetic_operations
{
    class Calc
    {
        public void Math(int a,int b)
        {
            int add= a + b;
            int sub = a - b;
            int mul= a * b;
            int div = a / b;
            Console.WriteLine($"Sum of {a} and {b} is {add}");
            Console.ReadLine();
            Console.WriteLine($"sub of {a} and {b} is {sub}");
            Console.ReadLine();
            Console.WriteLine($"Mul of {a} and {b} is {mul}");
            Console.ReadLine();
            Console.WriteLine($"Div of {a} and {b} is {div}");
            Console.ReadLine();

        }
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter 2 numbers ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Calc obj = new Calc();
            obj.Math(a, b);

        }
    }
}
