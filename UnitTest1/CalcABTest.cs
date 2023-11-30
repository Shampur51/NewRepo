using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WindowsFormsApp1.Pr3;

namespace UnitTest1
{
    [TestClass]
    public class CalcABTest
    {
        [TestMethod]
        public void Exep_Test()
        {
            var calc = new CalcAB(50, 10);

            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => calc.Sum());
        }

        [TestMethod]
        public void a_equal_b()
        {
            var calc = new CalcAB(10, 10);
            var testRes = 0;

            var res = calc.Sum();

            Assert.AreEqual(testRes, res);
        }

        [TestMethod]
        public void a5_b15_return50()
        {
            var calc = new CalcAB(5, 15);
            var testRes = 50;

            var res = calc.Sum();

            Assert.AreEqual(testRes, res);
        }
    }
}
