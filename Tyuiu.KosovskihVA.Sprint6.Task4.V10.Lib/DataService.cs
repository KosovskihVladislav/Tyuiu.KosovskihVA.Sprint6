using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KosovskihVA.Sprint6.Task4.V10.Lib
{
    public class DataService : ISprint6Task4V10
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] resultArray = new double[stopValue - startValue + 1];
            for (int x = startValue, count = 0; x <= stopValue; x++, count++)
            {
                double result = Math.Round((5 * x + 2.5)/(Math.Sin(x) + 3) + 2 * x + Math.Cos(x), 2);
                if (!(double.IsNaN(result) || double.IsInfinity(result)))
                {
                    resultArray[count] = result;
                }
                else
                {
                    resultArray[count] = 0;
                }
            }
            return resultArray;
        }
    }
}
