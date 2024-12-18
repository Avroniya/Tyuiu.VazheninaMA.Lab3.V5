using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveMathFirstExpression.Lib
{
    public class MathFirstExpression
    {
        public double CalculateFirstExpression(double a, double x, double y)
        {
            return 10 * x - ((x / y) / (2 * a / x)) + (3 * x + 2 * a - a) / (3 * a + 2 * x + y) - 2 * x;
        }
    }
}
