﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KosovskihVA.Sprint6.Task3.V11.Lib;

namespace Tyuiu.KosovskihVA.Sprint6.Task3.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService service1 = new DataService();
            int[,] testArray = { {27, -15, 14, 2, 27 },
                                 {-8, 14, -10, 33, 0 },
                                 {1, 7, -11, -11, 23 },
                                 {-13, -20, 15, -16, 34 },
                                 {-3, 1, -1, 5, 1 } };
            int[,] testArray1 = { {-13, -15, 14, 2, 27 },
                                 {-8, 14, -10, 33, 0 },
                                 {-3, 7, -11, -11, 23 },
                                 {1, -20, 15, -16, 34 },
                                 {27, 1, -1, 5, 1 } };
            CollectionAssert.AreEqual(testArray1, service1.Calculate(testArray));
        }
    }
}
