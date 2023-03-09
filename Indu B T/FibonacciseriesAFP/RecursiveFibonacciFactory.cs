﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciseriesAFP
{
    public class RecursiveFibonacciFactory : IFibonacciFactory
    {
        public IFibonacci Create()
        {
            return new RecursiveFibonacci();
        }
    }
}
