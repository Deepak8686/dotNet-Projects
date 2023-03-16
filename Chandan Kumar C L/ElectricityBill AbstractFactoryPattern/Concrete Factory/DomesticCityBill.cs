using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityBill_AbstractFactoryPattern.Concrete_Factory
{
    public class DomesticCityBill:IBill
    {
        private readonly int _units;
        public DomesticCityBill(int units)
        {
            _units = units;
        }

        public double BillCalculation(int units)
        {
            Calculation cal = new Calculation();
            double bill = cal.BillCalculation(units);
            return bill * 5;
        }
    }
}
