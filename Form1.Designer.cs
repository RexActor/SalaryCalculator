namespace SalaryCalculator_Elvis
{
    partial class Form1
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
            this.weekRota = new System.Windows.Forms.Button();
            this.infoTextRichBox = new System.Windows.Forms.RichTextBox();
            this.editValues = new System.Windows.Forms.Button();
            this.versionLabel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // weekRota
            // 
            this.weekRota.Location = new System.Drawing.Point(12, 94);
            this.weekRota.Name = "weekRota";
            this.weekRota.Size = new System.Drawing.Size(75, 24);
            this.weekRota.TabIndex = 0;
            this.weekRota.Text = "My Week ";
            this.weekRota.UseVisualStyleBackColor = true;
            this.weekRota.Click += new System.EventHandler(this.weekRota_Click);
            // 
            // infoTextRichBox
            // 
            this.infoTextRichBox.Location = new System.Drawing.Point(33, 17);
            this.infoTextRichBox.Name = "infoTextRichBox";
            this.infoTextRichBox.Size = new System.Drawing.Size(393, 64);
            this.infoTextRichBox.TabIndex = 1;
            this.infoTextRichBox.Text = "Some Information";
            this.infoTextRichBox.TextChanged += new System.EventHandler(this.infoTextRichBox_TextChanged);
            // 
            // editValues
            // 
            this.editValues.Location = new System.Drawing.Point(12, 138);
            this.editValues.Name = "editValues";
            this.editValues.Size = new System.Drawing.Size(75, 23);
            this.editValues.TabIndex = 2;
            this.editValues.Text = "Edit my data";
            this.editValues.UseVisualStyleBackColor = true;
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(9, 289);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(42, 13);
            this.versionLabel.TabIndex = 3;
            this.versionLabel.Text = "Version";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(340, 279);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.textBox2.Location = new System.Drawing.Point(223, 289);
            this.textBox2.Name = "textBox2";
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox2.Size = new System.Drawing.Size(111, 13);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Progress on Programm:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 302);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.editValues);
            this.Controls.Add(this.infoTextRichBox);
            this.Controls.Add(this.weekRota);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button weekRota;
        private System.Windows.Forms.RichTextBox infoTextRichBox;
        private System.Windows.Forms.Button editValues;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

