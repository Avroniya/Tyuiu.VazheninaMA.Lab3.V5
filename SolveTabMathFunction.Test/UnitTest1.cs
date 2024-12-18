using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SolveTabMathFunction.Lib;

namespace SolveTabMathFunction.Test
{
    [TestClass]
    public class ValidMathFuction
    {
        [TestMethod]
        public void TestCalculateMathFunction1()
        {
            {
                double[] array = { -10,
            -29.9375,
            648.335,
            66374,015,
            9843700.4,
            701.887,
            680.203,
            2.82,
            1.5,
            1
            };
              
                CollectionAssert.AreEqual(array, TabMathFunction.CalculateTabMathFunction(1, 11));
            }
        }
    }
}
