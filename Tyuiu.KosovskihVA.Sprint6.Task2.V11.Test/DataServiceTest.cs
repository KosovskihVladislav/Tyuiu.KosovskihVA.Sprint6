using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KosovskihVA.Sprint6.Task2.V11.Lib;

namespace Tyuiu.KosovskihVA.Sprint6.Task2.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService service1 = new DataService();
            double[] TestArray = new double[] { -15.44, -10.93, -7.22, -5.04, 0, -0.3, 2.57, 6.4, 10.04, 12.72, 14.68 };
            CollectionAssert.AreEqual(TestArray, service1.GetMassFunction(-5, 5));
        }
    }
}
