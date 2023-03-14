﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciseriesRI
{
    // Implement the RecursiveFibonacci class that implements the IFibonacci interface recursively
    public class RecursiveFibonacci : IFibonacci
    {
        public int Calculate(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return Calculate(n - 1) + Calculate(n - 2);
            }
        }
    }
}
