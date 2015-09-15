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
    public partial class Calendar_test : Form
    {
        public Calendar_test()
        {
            InitializeComponent();
        }

        private void Calendar_test_Load(object sender, EventArgs e)
        {
            MPK_Calendar.MPK_Calendar cal = new MPK_Calendar.MPK_Calendar();
            this.Controls.Add(cal);
        }
    }
}
