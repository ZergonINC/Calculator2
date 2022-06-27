﻿using Calculator2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator2.Model.CalculationOperations
{
    public class Power : IArithmetic
    {
        public double Result(double x, double y) => Math.Pow(x, y);
    }
}
