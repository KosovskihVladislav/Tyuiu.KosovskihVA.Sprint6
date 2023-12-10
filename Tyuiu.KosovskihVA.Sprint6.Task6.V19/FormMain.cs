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
using Tyuiu.KosovskihVA.Sprint6.Task6.V19.Lib;

namespace Tyuiu.KosovskihVA.Sprint6.Task6.V19
{
    public partial class FormMain : Form
    {
        DataService service = new DataService();
        string filePath;
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            filePath = openFileDialogTask.FileName;
            textBoxInput.Text = File.ReadAllText(filePath);
            groupBoxInput.Text += " " + filePath;
            buttonExecute.Enabled = true;
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = service.CollectTextFromFile(filePath);
        }
    }
}
