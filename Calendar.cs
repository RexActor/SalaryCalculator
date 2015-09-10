using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SalaryCalculator_Elvis
{

    public partial class Calendar : Form
    {
        Button addMonth = new Button();
        Button reduceMonth = new Button();
        Dictionary<string, string> dateColorDictionary = new Dictionary<string, string>();
        Label monthYear = new Label();
        DateTime timeNow;

        public Calendar()
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

        public void generateCalendar()
        {
            // dictionary.Add("1","Color.AliceBlue");

            this.SuspendLayout();

            /*
            Generate month and year in form
            */

            // DateTime.Now.Ad
            timeNow = DateTime.Today;
            monthYear.Text = timeNow.ToString("Y");
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
                    Label t = new Label();
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

                    t.Visible = counter < 32;//hide dates after 31st
                    counter++;
                }
        }

        private void nextMonth(object sender, EventArgs e)
        {
            Button click = (Button)sender;
            if (click != null)
            {
                DateTime newDate = new DateTime();
                newDate = DateTime.Parse(monthYear.Text);
                monthYear.Text = newDate.AddMonths(1).ToString("Y");
            }
        }
        private void prevMonth(object sender, EventArgs e)
        {
            Button click = (Button)sender;
            if (click != null)
            {
                DateTime newDate = new DateTime();
                newDate = DateTime.Parse(monthYear.Text);
                monthYear.Text = newDate.AddMonths(-1).ToString("Y");
            }
        }

        private void labelClick(object sender, EventArgs e)
        {
            /*
            dictionary creation for date color change saving
            */

            Label button = (Label)sender;

            if (button.BackColor == Color.AliceBlue)
            {
                if (dateColorDictionary.Count == 0)
                {

                    dateColorDictionary.Add(button.Text, "Color.Green");
                }
                else if (dateColorDictionary.Count != 0)
                {
                    dateColorDictionary.Remove(button.Text);
                    dateColorDictionary.Add(button.Text, "Color.Green");
                }

                else if (dateColorDictionary.Count != 0)
                {
                    dateColorDictionary.Remove(button.Text);

                }
                button.BackColor = Color.Green;

            }
            else if (button.BackColor == Color.Green)
            {
                dateColorDictionary.Remove(button.Text);
                dateColorDictionary.Add(button.Text, "Color.Red");
                button.BackColor = Color.Red;
            }
            else if (button.BackColor == Color.Red)
            {
                dateColorDictionary.Remove(button.Text);
                dateColorDictionary.Add(button.Text, "Color.Yellow");
                button.BackColor = Color.Yellow;
            }
            else if (button.BackColor == Color.Yellow)
            {
                dateColorDictionary.Remove(button.Text);
                dateColorDictionary.Add(button.Text, "Color.Blue");
                button.BackColor = Color.Blue;
            }

            else
            {

                dateColorDictionary.Remove(button.Text);
                // dateColorDictionary.Add(button.Text, "Color.AliceBlue");
                button.BackColor = Color.AliceBlue;

            }
            /*
            for testing array in our test window
            */

            testWindow.Text = string.Join(" ", dateColorDictionary);

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

        private void saveCalendarButton_Click(object sender, EventArgs e)
        {
            generateCalendar();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
