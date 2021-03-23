using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TDDExercise
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            CalcLib.Calculation objc = new CalcLib.Calculation();
            double num = 16;
            double square = num * num;
            double sqrt = Math.Sqrt(num);
            double cube = num * num * num;

            Assert.AreEqual(square, objc.Square(num));
            Assert.AreEqual(sqrt, objc.Sqrt(num));
            Assert.AreEqual(cube, objc.Cube(num));

        }
    }
}
