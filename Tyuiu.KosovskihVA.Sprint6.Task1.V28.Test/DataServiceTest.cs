using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KosovskihVA.Sprint6.Task1.V28.Lib;

namespace Tyuiu.KosovskihVA.Sprint6.Task1.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        

        [TestMethod]
        public void TestMethod1()
        {
            DataService service1 = new DataService();
            double[] TestArray = new double[] { 4.67, 0.43, -8.26, -9.87, -3.98, 1.00, 0.02, -1.87, 3.74, 16.43, 24.67 };
            CollectionAssert.AreEqual(TestArray, service1.GetMassFunction(-5, 5));
        }
    }
}
