using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KosovskihVA.Sprint6.Task7.V27.Lib
{
    public class DataService : ISprint6Task7V27
    {
        public int[,] GetMatrix(string path)
        {
            string content = File.ReadAllText(path);
            int[,] matrix = new int[content.Count(x => x == '\n'), content.Split('\n')[0].Split(';').Length];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string[] str = content.Split('\n');
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = Convert.ToInt32(str[i].Split(';')[j]);
                    if (i == 4 && matrix[i, j] < 0)
                    {
                        matrix[i, j] = -1;
                    }
                }
            }
            return matrix;
        }
    }
}
