using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyFirstCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstCalculator.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void SumTest()
        {
            var Calculator = new Calculator();
            Assert.IsTrue(Calculator.Sum(2, 2) == 4);
        }

        [TestMethod()]
        public void SubstractTest()
        {
            var Calculator = new Calculator();
            Assert.IsTrue(Calculator.Substract(2, 2) == 0);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            var Calculator = new Calculator();
            Assert.IsTrue(Calculator.Multiply(2, 4) == 8);
        }

        [TestMethod()]
        public void DivideTest()
        {
            var Calculator = new Calculator();
            Assert.IsTrue(Calculator.Divide(10, 2) == 5);
        }
    }
}