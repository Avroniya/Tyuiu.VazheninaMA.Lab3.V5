﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SolveMathFirstExpression.Lib;

namespace SolveMathFirstExpression.Test
{
    [TestClass]
    public class ValidMathFirstExpression
    {
        [TestMethod]
        public void TestCalculateFirstExpression()
        {
            double a = 1;
            double x = 2;
            double y = 2;
            MathFirstExpression expr = new MathFirstExpression();

            double res = expr.CalculateFirstExpression(a, x, y);
            double wait = 8.375;

            Assert.AreEqual(Math.Round(wait, 1), Math.Round(res, 1));
        }
    }
}
