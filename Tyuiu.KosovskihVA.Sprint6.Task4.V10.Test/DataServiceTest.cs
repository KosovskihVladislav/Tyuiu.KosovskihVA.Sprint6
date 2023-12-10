using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KosovskihVA.Sprint6.Task4.V10.Lib;

namespace Tyuiu.KosovskihVA.Sprint6.Task4.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService service = new DataService();
            CollectionAssert.AreEqual(new double[] { -15.4, -13.31, -11.36, -8, -2.62, 1.83, 4.49, 6.78, 10.58, 17.38, 23.76 }, service.GetMassFunction(-5, 5));
        }
    }
}
