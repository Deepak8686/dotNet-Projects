using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    internal class VillageRate: IRateCalculator
    {
        
            private readonly int _units;

            public VillageRate(int units)
            {
                _units = units;
            }
            public double Calculate(int units)
            {
                return 0;
            }
        }
}
