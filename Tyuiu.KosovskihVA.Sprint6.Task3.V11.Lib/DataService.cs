using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KosovskihVA.Sprint6.Task3.V11.Lib
{
    public class DataService : ISprint6Task3V11
    {
        public int[,] Calculate(int[,] matrix)
        {
            int[] kal = new int[matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                kal[i] = matrix[i, 0];
            }
            Array.Sort(kal);

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
               matrix[i, 0] = kal[i];
            }
            return matrix;
        }
    }
}
