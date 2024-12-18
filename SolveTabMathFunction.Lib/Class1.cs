﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveTabMathFunction.Lib
{
    public class TabMathFunction
    {
        public static double[] CalculateTabMathFunction(int startValue, int stopValue)
        {
            var res = new double[10];
            double x = startValue;
            for (int i = 0; i < 10; i++)
            {
                x = +i * (stopValue - startValue) / 10;
                res[i] = Math.Pow((Math.Pow(x, 2) + (1 / Math.Pow(x, 2))), x) - 12 * (Math.Pow(x, 2));
            }
            return res;
        }
    }
}
