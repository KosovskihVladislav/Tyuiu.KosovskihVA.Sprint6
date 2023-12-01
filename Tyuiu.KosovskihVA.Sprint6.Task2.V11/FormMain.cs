using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KosovskihVA.Sprint6.Task2.V11.Lib;

namespace Tyuiu.KosovskihVA.Sprint6.Task2.V11
{
    public partial class FormMain : Form
    {
        DataService service1 = new DataService();
        public FormMain()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBox5.Text);
                int stopStep = Convert.ToInt32(textBox6.Text);

                int len = service1.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray = new double[len];
                valueArray = service1.GetMassFunction(startStep, stopStep);

                this.chart1.Titles.Add("График функции sin(x)");
                this.chart1.ChartAreas[0].AxisX.Title = "Ось X";
                this.chart1.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridView1.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chart1.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введен неправильный диапазон", "Ошибка");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Задание выполнил студент группы ПКТб-23-2 Косовских В.А.", "Сообщение");
        }
    }
}
