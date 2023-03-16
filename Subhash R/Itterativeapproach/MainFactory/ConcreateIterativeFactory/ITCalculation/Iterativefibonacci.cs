using Itterativeapproach.MainFactory.IterativeFactory.InterfaceIterative;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itterativeapproach.MainFactory.IterativeFactory.ITCalculation
{
    public class Iterativefibonacci : ITerativeInterface1
    {
        private readonly double _IFibo;

        public Iterativefibonacci(double IFibo)
        {
            _IFibo = IFibo;
        }
        public void Iterativefibo()
        {
            try
            {
                int firstnumber = 0, secondnumber = 1, result, i;
                Console.WriteLine(" the length of fibonaci series");
                Console.WriteLine(firstnumber+" \n"+secondnumber+" ");
                for (i=2; i < _IFibo; i++)
                {
                    result=firstnumber + secondnumber;
                    Console.WriteLine(result+"  ");
                    firstnumber=secondnumber;
                    secondnumber=result;
                }

            }
            catch (Exception )
            {
                Console.WriteLine("enter a numercal value");
            }

        }
    }
}
