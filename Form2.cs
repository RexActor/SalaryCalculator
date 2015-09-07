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

    public partial class Form2 : Form
    {
        Button addMonth = new Button();
        Button reduceMonth = new Button();
        Label monthYear = new Label();

        public Form2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            //monthCalendar1.Al

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 478);
            this.Name = "Form2";
            this.Text = "Calendar";
            this.ResumeLayout(false);
            generateCalendar();
        }

        private void generateCalendar()
        {
            this.SuspendLayout();
            /*
            Generate month and year in form
            */

            // DateTime.Now.Ad
            monthYear.Text = DateTime.Now.ToString("Y");
            monthYear.Size = new System.Drawing.Size(200, 40);
            monthYear.Location = new Point(200, 10);
            monthYear.Visible = true;
            monthYear.Font = new Font(monthYear.Font, FontStyle.Bold);
            monthYear.Font = new Font(monthYear.Font.FontFamily, 18);
            // monthYear.Font.Size = 24;
            this.Controls.Add(monthYear);

            /*
            Generates button for changing month forward
            */
            addMonth.Text = "Next Month";
            addMonth.Visible = true;
            addMonth.Location = new Point(500, 15);
            addMonth.Click += new EventHandler(nextMonth);
            this.Controls.Add(addMonth);

            /*
            generates button for changing month backwards
            */
            reduceMonth.Text = "Prev. Month";
            reduceMonth.Visible = true;
            reduceMonth.Location = new Point(20, 15);
            reduceMonth.Click += new EventHandler(prevMonth);
            this.Controls.Add(reduceMonth);

            /*
            Generates week day names
            */

            int counter = 1;
            string[] weekDayArray = new String[7] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            for (int z = 0; z < 7; z++)
            {
                Label weekDays = new Label();
                weekDays.Name = "Weekday" + z.ToString();

                weekDays.Size = new System.Drawing.Size(75, 50);
                weekDays.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                weekDays.Location = new Point(20 + (z * 74), 50);
                weekDays.Visible = true;
                weekDays.BackColor = Color.BlanchedAlmond;
                weekDays.Font = new Font(weekDays.Font, FontStyle.Bold);
                weekDays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                weekDays.Text = weekDayArray[z].ToString();
                this.Controls.Add(weekDays);
            }

            /*
            Generates dates for month
            Big thanks for @purposelydrifting for help
            */
            for (int y = 0; y < 5; y++)
                for (int x = 0; x < 7; x++)
                {
                    System.Windows.Forms.Label t = new System.Windows.Forms.Label();
                    t.BackColor = System.Drawing.Color.White;
                    t.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    t.Location = new System.Drawing.Point(20 + (x * 74), 99 + (y * 49));
                    t.Name = "lblSquare" + counter.ToString();
                    t.Size = new System.Drawing.Size(75, 50);
                    t.TabIndex = counter - 1;
                    t.Text = counter.ToString();
                    t.BackColor = Color.AliceBlue;
                    t.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    t.Click += new EventHandler(labelClick);
                    // bool lblClicked = true;

                    this.Controls.Add(t);

                    counter++;

                    /*
                    Lets hide dates which ones are biger than 31
                    */
                    if (t.Name.Contains("32") || t.Name.Contains("33") || t.Name.Contains("34") || t.Name.Contains("35"))
                    {
                        t.Visible = false;
                    }
                }
        }
        private void nextMonth(object sender, EventArgs e)
        {
            monthYear.Text = DateTime.Now.AddMonths(1).ToString("Y");

        }
        private void prevMonth(object sender, EventArgs e)
        {
            Button click = (Button)sender;

            click = null;
            while (click == null)
            {
                monthYear.Text = DateTime.Now.AddMonths(-1).ToString("Y");
                // click = null;
            }
        }

        private void labelClick(object sender, EventArgs e)
        {
            Label button = (Label)sender;

            if (button.BackColor == Color.AliceBlue)
            {
                button.BackColor = Color.Green;
            }
            else if (button.BackColor == Color.Green)
            {
                button.BackColor = Color.Red;
            }
            else if (button.BackColor == Color.Red)
            {
                button.BackColor = Color.Yellow;
            }
            else
                button.BackColor = Color.AliceBlue;

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            //this.testWindow.Text = this.monthCalendar1.SelectionRange.Start+" to "+this.monthCalendar1.SelectionRange.End;

        }

        private void testWindow_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
