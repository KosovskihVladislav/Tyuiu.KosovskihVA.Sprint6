﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.KosovskihVA.Sprint6.Task5.V8.Lib;

namespace Tyuiu.KosovskihVA.Sprint6.Task5.V8
{
    public partial class FormMain : Form
    {
        private static readonly string path = @"C:\DataSprint5\InPutFileTask5V8.txt";
        DataService service = new DataService();
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Задание выполнил студент группы ПКТб 23-2 Косовских В.А.", "Справка");
        }

        private void buttonOpenData_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            dataGridViewData.Rows.Clear();
            chartData.Series[0].Points.Clear();

            dataGridViewData.ColumnCount = 2;
            dataGridViewData.Columns[0].Width = 20;
            dataGridViewData.Columns[1].Width = 50;

            chartData.ChartAreas[0].AxisX.Title = "Ось X";
            chartData.ChartAreas[0].AxisY.Title = "Ось Y";

            double[] serviceArray = service.LoadFromDataFile(path);
            for (int i = 0; i < serviceArray.Length; i++)
            {
                dataGridViewData.Rows.Add(i + 1, serviceArray[i]);
                chartData.Series[0].Points.AddXY(i, serviceArray[i]);
            }
        }
    }
}
