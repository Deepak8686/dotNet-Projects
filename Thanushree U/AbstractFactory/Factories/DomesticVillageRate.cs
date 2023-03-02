using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    public class DomesticVillageRate: IRateCalculator
    {
        private readonly int _units;
        public DomesticVillageRate(int units)
        {
            _units = units;
        }
        public double Calculate(int units)
        {
            Units_calculation cal = new Units_calculation();
            double a = cal.Calculation(units);
            return a * 1;
        }
    }
}
