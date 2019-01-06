using Microsoft.VisualStudio.TestTools.UnitTesting;
using BBADemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBADemo.Tests
{
    [TestClass()]
    public class CalculationTests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            int expected = 5;

            int a = 10;

            int b = 5;

            int actual = new NewCalculation().Calculate(a, b);

            Assert.AreEqual(expected, actual);
        }
    }
}