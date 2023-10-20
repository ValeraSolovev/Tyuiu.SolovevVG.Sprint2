using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SolovevVG.Sprint2.Task7.V15.Lib;


namespace Tyuiu.SolovevVG.Sprint2.Task7.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            int x = 2, y = 9;
            bool res = dataService.CheckDotInShadedArea(x, y), wait = false;
            Assert.AreEqual(wait, res);
        }
    }
}
