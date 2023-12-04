using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WindowsFormsApp1.Pr4;

namespace UnitTestPr4
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Calculate_true()
        {
            var arraysAB = new ArraysAB();
            arraysAB.a = new double[] { 1,1,1,1,1,1,1,1,1,1 };
            arraysAB.b = new double[] { 3,3,3,3,3,3,3,3,3,3 };

            // Act
            bool result = arraysAB.calculate();

            // Assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test_Calculate_false()
        {
            var arraysAB = new ArraysAB();
            arraysAB.a = new double[] { 1, 4, 1, 1, 1, 115, 61, 1, 1, 1 };
            arraysAB.b = new double[] { 3, 3, 6, 3, 22, 3, 3, 3, 3, 3 };

            // Act
            bool result = arraysAB.calculate();

            // Assert
            Assert.AreEqual(false, result);
        }
    }
}
