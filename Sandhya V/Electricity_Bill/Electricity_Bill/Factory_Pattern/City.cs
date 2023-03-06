using Electricity_Bill.Factory_Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electricity_Bill
{
    internal class City: InterfaceEBill
    {
        private readonly int _units;

        public City(int units) { 

            _units=units;
        
        }    

        public int total_amount(int total)
        {
            Calculation obj=new Calculation();
            var result=obj.total_amount(total);
            return result*10;
        }
    }
}
