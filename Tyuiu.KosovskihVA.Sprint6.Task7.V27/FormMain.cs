using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.KosovskihVA.Sprint6.Task7.V27.Lib;

namespace Tyuiu.KosovskihVA.Sprint6.Task7.V27
{
    public partial class FormMain : Form
    {
        DataService service = new DataService();
        string path;
        public FormMain()
        {
            InitializeComponent();
            openFileDialog.Filter = "Значения разделённые точками(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialog.Filter = "Значения разделённые точками(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.Show();
        }

        private void buttonFileDialog_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            path = openFileDialog.FileName;
            groupBoxInput.Text += " " + path;
            buttonExecute.Enabled = true;
            buttonSave.Enabled = true;


            string content = File.ReadAllText(path);
            int[,] matrix = new int[content.Count(x => x == '\n'), content.Split('\n')[0].Split(';').Length];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string[] str = content.Split('\n');
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = Convert.ToInt32(str[i].Split(';')[j]);
                }
            }
            dataGridViewInput.ColumnCount = matrix.GetLength(1);
            dataGridViewInput.RowCount = matrix.GetLength(0);

            dataGridViewOutput.ColumnCount = matrix.GetLength(1);
            dataGridViewOutput.RowCount = matrix.GetLength(0);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    dataGridViewInput.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewInput.ColumnCount = 50;
            dataGridViewOutput.ColumnCount = 50;

            dataGridViewInput.RowCount = 50;
            dataGridViewOutput.RowCount = 50;

            for (int i = 0; i < dataGridViewInput.ColumnCount; i++)
            {
                dataGridViewInput.Columns[i].Width = 25;
                dataGridViewOutput.Columns[i].Width = 25;
            }
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            int[,] serviceMatrix = service.GetMatrix(path);
            for (int i = 0; i < serviceMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < serviceMatrix.GetLength(1); j++)
                {
                    dataGridViewOutput.Rows[i].Cells[j].Value = serviceMatrix[i, j];
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            int[,] serviceMatrix = service.GetMatrix(path);
            saveFileDialog.FileName = "OutputFileTask7";
            saveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog.ShowDialog();

            string savePath = saveFileDialog.FileName;

            string str = "";
            for (int i = 0; i < serviceMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < serviceMatrix.GetLength(1); j++)
                {
                    if (j != serviceMatrix.GetLength(1) - 1)
                    {
                        str += serviceMatrix[i, j].ToString() + ";";
                    }
                    else
                    {
                        str += serviceMatrix[i, j].ToString() + Environment.NewLine;
                    }
                }
            }
            File.WriteAllText(savePath, str);
        }

        private void dataGridViewInput_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
