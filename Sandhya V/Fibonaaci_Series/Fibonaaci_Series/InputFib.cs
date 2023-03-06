using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonaaci_Series
{
    public  class InputFib : InterfaceFibonacci
    {
        public  string Getdata(string data)
        {
            Console.WriteLine(data);
            return Console.ReadLine();
        }

       
    }
        
    
}
