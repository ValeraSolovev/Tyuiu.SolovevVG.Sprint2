﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SolovevVG.Sprint2.Task1.V29.Lib;

namespace Tyuiu.SolovevVG.Sprint2.Task1.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();
            int a = 657, b = 654, c = 657, d = 657;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = new bool[6] { true, true, true, false, true, true };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
