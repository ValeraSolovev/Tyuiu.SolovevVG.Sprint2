using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SolovevVG.Sprint2.Task4.V5.Lib;

namespace Tyuiu.SolovevVG.Sprint2.Task4.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 5.0, y = 1.0;
            var z = ds.Calculate(x, y);
            Assert.AreEqual(76, z);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 2.0, y = 1.0;
            var z = ds.Calculate(x, y);
            Assert.AreEqual(25, z);
        }

    }
}
