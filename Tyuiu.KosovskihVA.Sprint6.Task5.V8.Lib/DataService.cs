using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KosovskihVA.Sprint6.Task5.V8.Lib
{
    public class DataService : ISprint6Task5V8
    {
        public double[] LoadFromDataFile(string path)
        {
            string[] lines = File.ReadAllLines(path);
            double[] res = new double[0];
            foreach (string line in lines)
            {
                string[] numberStrings = line.Split(' ');
                foreach (string numberString in numberStrings)
                {
                    double parsedNumber;
                    if (double.TryParse(numberString, out parsedNumber) && parsedNumber < 0)
                    {
                        Array.Resize(ref res, res.Length + 1);
                        res[res.Length - 1] = Math.Round(parsedNumber, 3);
                    }
                }
            }
            return res;
        }
    }
}
