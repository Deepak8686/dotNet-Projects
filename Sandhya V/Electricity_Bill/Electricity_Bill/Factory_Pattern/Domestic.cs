﻿using Electricity_Bill.Factory_Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electricity_Bill
{
    public class Domestictown:InterfaceEBill
    {
        private readonly int _units;

        public Domestictown(int units)
        {
            _units = units;

        }

        public int total_amount(int total)
        {
            Calculation obj = new Calculation();
            var result = obj.total_amount(total);
            return result * 5;
        }
    }
}
