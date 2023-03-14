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
            bool check=true,check1=true,check3;
            IFibonacci fibo;
            double n=0;                       
               Console.WriteLine("\nEnter I for Iterative Fibonaci series and R for Recursive Fibonacci series \n ");
               type = Console.ReadLine();                
                if (type.ToUpper() == "R")
                {
                   do
                   {
                        try
                        {
                            Console.WriteLine("\nEnter number of Fibonacci series you want to generate\n");
                            n = Math.Round(Convert.ToDouble(Console.ReadLine()));
                            if (n <= 0)
                            {
                            Console.WriteLine("\nEnter positive integer greater than 0");
                            check1 = false;
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("\nInvalid Input! Enter a Number\n ");
                            check1 = false;
                        }
                    
                   } while (check1 == false);
                        for (int i = 0; i < n; i++)
                        {
                            fibo = new Fibonacci_Recursive(i);
                            double R_Series = fibo.Fibonacci(i);
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
                            n = Math.Round(Convert.ToDouble(Console.ReadLine()));
                            if (n <= 0)
                            {
                                Console.WriteLine("Input must be a positive integer greater than 0.");
                                check= false;
                            }                        
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("\nInvalid Input! Enter a Number\n ");
                            check = false;
                        }
                    }while (check == false);
                    fibo = new Fibonacci_Iterative(n);
                    Console.WriteLine("\nFibonacci iterative \n");
                    fibo.Fibonacci(n);                    
                }
                else
                {
                    Console.WriteLine("\nInvalid Choice!\n");
                    Valid();                
                }
                do
                {
                    Console.WriteLine("\n\nDo you want to generate Fibonacci series again (Y/N)\n");
                    string y = Console.ReadLine();
                    if (y.ToUpper() == "Y")
                    {
                        Valid();
                        check3 = false;
                    }
                    else if (y.ToUpper() == "N")
                    {
                        Console.WriteLine("\nOkay! Press any key to exit");
                        Console.ReadKey();
                        Environment.Exit(0);
                        check3= false;                    
                    }
                    else
                    {
                    Console.WriteLine("Invalid choice!");
                    check3= true;
                    }
                }while(check3==true);
            
        }                                
    }
}
