using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KosovskihVA.Sprint6.Task3.V11.Lib;


namespace Tyuiu.KosovskihVA.Sprint6.Task3.V11
{
    public partial class FormMain : Form
    {
        int[,] matrix = { {27, -15, 14, 2, 27 },
                                 {-8, 14, -10, 33, 0 },
                                 {1, 7, -11, -11, 23 },
                                 {-13, -20, 15, -16, 34 },
                                 {-3, 1, -1, 5, 1 } };
        DataService service1 = new DataService();

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewOutput.RowCount = matrix.GetLength(0);
            dataGridViewOutput.ColumnCount = matrix.GetLength(1);
            for (int i = 0; i < dataGridViewOutput.ColumnCount; i++)
            {
                dataGridViewOutput.Columns[i].Width = 25;
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    dataGridViewOutput.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
        }
        public FormMain()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            matrix = service1.Calculate(matrix);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    dataGridViewOutput.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Задание выполнил студент группы ПКТб 23-2 Косовских В.А.", "Справка");
        }
    }
}
