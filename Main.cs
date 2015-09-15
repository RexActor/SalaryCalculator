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
    public partial class mainForm : Form
    {
        string version = "V0.1";
        public mainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            progressBar1.ForeColor = Color.Red;
            this.progressBar1.Value = 30;
         
            this.Text = "Salary Calculator";
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            this.infoTextRichBox.Text = "This software is designe" +
            "specialy for tracing your salary in specific situation";
            this.versionLabel.Text = version;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
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

        private void editValues_Click(object sender, EventArgs e)
        {
            Calendar_test calendar = new Calendar_test();
            calendar.Show();
        }
    }
}
