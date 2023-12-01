using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KosovskihVA.Sprint6.Task1.V28.Lib;

namespace Tyuiu.KosovskihVA.Sprint6.Task1.V28
{
    public partial class FormMain : Form
    {
        DataService service1 = new DataService();
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Задание выполнил студент группы ПКТб-23-2 Косовских В.А.", "Сообщение");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBox5.Text);
                int stopStep = Convert.ToInt32(textBox6.Text);

                string strLine;

                int len = service1.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray = new double[len];
                valueArray = service1.GetMassFunction(startStep, stopStep);

                textBox2.Text = "";
                textBox2.AppendText("+-----------+-----------+" + Environment.NewLine);
                textBox2.AppendText("|     X     |    f(x)    |" + Environment.NewLine);
                textBox2.AppendText("+-----------+-----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("| {0,5:d}     |  {1, 5:f2}   |", startStep, valueArray[i]);
                    textBox2.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textBox2.AppendText("+-----------+-----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Успех!", "Ошибка");
            }
        }
    }
}
