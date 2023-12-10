using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KosovskihVA.Sprint6.Task5.V8.Lib;
using System.IO;

namespace Tyuiu.KosovskihVA.Sprint6.Task5.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutFileTask5V8.txt";
            DataService service = new DataService();
            CollectionAssert.AreEqual(new double[] { -13, -19, -9.82, -9.71, -0.11, -17.36, -12, -12.35 }, service.LoadFromDataFile(path));
        }
    }
}
