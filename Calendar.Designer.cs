namespace SalaryCalculator_Elvis
{
    partial class Calendar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.testWindow = new System.Windows.Forms.RichTextBox();
            this.saveCalendarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // testWindow
            // 
            this.testWindow.Location = new System.Drawing.Point(49, 408);
            this.testWindow.Name = "testWindow";
            this.testWindow.Size = new System.Drawing.Size(681, 168);
            this.testWindow.TabIndex = 0;
            this.testWindow.Text = "";
            // 
            // saveCalendarButton
            // 
            this.saveCalendarButton.Location = new System.Drawing.Point(494, 336);
            this.saveCalendarButton.Name = "saveCalendarButton";
            this.saveCalendarButton.Size = new System.Drawing.Size(75, 23);
            this.saveCalendarButton.TabIndex = 1;
            this.saveCalendarButton.Text = "Save";
            this.saveCalendarButton.UseVisualStyleBackColor = true;
            this.saveCalendarButton.Click += new System.EventHandler(this.saveCalendarButton_Click);
            // 
            // Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 617);
            this.Controls.Add(this.saveCalendarButton);
            this.Controls.Add(this.testWindow);
            this.Name = "Calendar";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox testWindow;
        private System.Windows.Forms.Button saveCalendarButton;
    }
}