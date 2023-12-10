using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.KosovskihVA.Sprint6.Task7.V27.Lib;

namespace Tyuiu.KosovskihVA.Sprint6.Task7.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService service = new DataService();

            string testPath = @"C:\DataSprint5\1122.csv";
            int[,] testMatrix = new int[6, 6];
            for (int i = 0; i < testMatrix.GetLength(0); i++)
            {
                testMatrix[4, i] = -1;
            }
            int[,] tests = service.GetMatrix(testPath);
            for (int i = 0; i < testMatrix.GetLength(1); i++)
            {
                Assert.AreEqual(testMatrix[4, i], tests[4, i]);
            }
        }
    }
}
