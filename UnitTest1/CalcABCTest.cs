using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WindowsFormsApp1.Pr3;

namespace UnitTest1
{
    [TestClass]
    public class CalcABCTest
    {
        [TestMethod]
        public void res_parne_nep_nep()
        {
            var calc = new CalcABC(4, 5, 3);
            var TestRes = 1728;

            var Res = calc.rez();

            Assert.AreEqual(TestRes, Res);
        }

        [TestMethod]
        public void res_nep_parne_nep()
        {
            var calc = new CalcABC(5, 4, 3);
            var TestRes = 1728;

            var Res = calc.rez();

            Assert.AreEqual(TestRes, Res);
        }

        [TestMethod]
        public void res_nep_nep_parne()
        {
            var calc = new CalcABC(3, 5, 4);
            var TestRes = 1728;

            var Res = calc.rez();

            Assert.AreEqual(TestRes, Res);
        }

        [TestMethod]
        public void res_nep_nep_nep()
        {
            var calc = new CalcABC(3, 5, 1);
            var TestRes = 153;

            var Res = calc.rez();

            Assert.AreEqual(TestRes, Res);
        }
    }
}
