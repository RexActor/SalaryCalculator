using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculator_Elvis
{
    public partial class Main : Form
    {
        string version = "V0.1";
        public Main()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.progressBar1.Value = 20;
            this.Text = "Salary Calculator";
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            this.infoTextRichBox.Text = "This software is designe" +
            "specialy for tracing your salary in specific situation";
            this.versionLabel.Text = version;
        }

        private void weekRota_Click(object sender, EventArgs e)
        {
            Calendar m = new Calendar();
            m.Show();
        }

        private void infoTextRichBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }


    }
}
