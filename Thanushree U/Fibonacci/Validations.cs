using Fibonacci.Concrete_factories;
using Fibonacci.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    public class Validations
    {
        public void Valid() 
        {
            
            string type;
            bool check=true, check1=true;
            IFibonacci fibo;
            int n=0;                       
               Console.WriteLine("\nEnter I for Iterative Fibonaci series and R for Recursive Fibonacci series \n ");
               type = Console.ReadLine();          
                if (type.ToUpper() == "R")
                {
                   do
                   {
                        check1 = true;
                        try
                        {
                        Console.WriteLine("\nEnter number of Fibonacci series you want to generate\n");
                        n = Convert.ToInt32(Console.ReadLine());
                       
                        }
                            catch (Exception)
                        {
                            Console.WriteLine("\nInvalid Input! Enter a Number\n ");
                            check1 = false;

                        }
                    if (n <= 0)
                    {
                        Console.WriteLine("Invalid number! Enter positive integer only");
                        Validations v = new Validations();
                        v.Valid();
                    }
                } while (check1 == false);
                        for (int i = 0; i < n; i++)
                        {
                            fibo = new Fibonacci_Recursive(i);
                            int R_Series = fibo.Fibonacci(i);
                            Console.WriteLine($"\nFibonacci recursive({i}) {R_Series} \n");
                        }
                   
                }
                 else if (type.ToUpper() == "I")
                 {
                    do
                    {
                        try
                        {
                            Console.WriteLine("\n\nEnter number of Fibonacci series you want to generate\n");
                            n = Convert.ToInt32(Console.ReadLine());
                            check= true;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("\nInvalid Input! Enter a Number\n ");
                            check = false;

                        }
                    } while (check == false);
                    fibo = new Fibonacci_Iterative(n);
                    Console.WriteLine("\nFibonacci iterative \n");
                    int a= fibo.Fibonacci(n);                    
                 }
                 else
                 {
                    Console.WriteLine("\nInvalid Choice!\n");
                    Valid();                
                 }
            Console.WriteLine("\n\nIf you want to generate Fibonacci series again Type 'Y'\n");
                    string y =Console.ReadLine();
            if (y.ToUpper() == "Y")
            {
                Valid();
            }         
            
        }                                
    }
}
