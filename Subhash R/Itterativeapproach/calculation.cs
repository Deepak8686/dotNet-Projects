using Itterativeapproach.MainFactory.IterativeFactory.InterfaceIterative;
using Itterativeapproach.MainFactory.IterativeFactory.ITCalculation;
using Itterativeapproach.MainFactory.RecursiveFactory.InterfaceRecursive;
using Itterativeapproach.MainFactory.RecursiveFactory.RECalculation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Itterativeapproach
{
    public class calculation
    {
        int value,options;
        public void calc()
        {
            ITerativeInterface1 iterativeInterface1 = null;
            RecursiveInterface1 recursiveInterface1= null;
           
            try
            {
                Console.WriteLine("Enter the length of fibonaci series");
                value = Convert.ToInt32(Console.ReadLine());
                if (value<=0)
                {
                    Console.WriteLine("Enter the number positive number and should be above zero");
                    calc();
                }
                valid();
            }
            catch(Exception)
            {
                Console.WriteLine("please enter Number only");
                calc();
            }
            void valid()
            {
                try
                {

                    Console.WriteLine("Enter 1 for iterative approach and 2 for recursive approach");
                    options = Convert.ToInt32(Console.ReadLine());
                    if (options == 1 || options == 2)
                    {
                        optionmethod();
                    }
                    else
                    {
                        Console.WriteLine("enter valid option");
                        valid();
                    }
                }catch(Exception)
                {
                    Console.WriteLine("enter the valid option");
                    valid();

                }

                void optionmethod()
                {
                    switch (options)
                    {
                        case 1:
                            iterativeInterface1=new Iterativefibonacci(value);
                            iterativeInterface1.Iterativefibo();
                            break;

                        case 2:
                            recursiveInterface1= new RecusiveFibonacci(value);
                            recursiveInterface1.Recursivecal();
                            break;

                        default:
                            Console.WriteLine("enter valid option");
                            break;
                    }
                }
            }
        }
    }
}
