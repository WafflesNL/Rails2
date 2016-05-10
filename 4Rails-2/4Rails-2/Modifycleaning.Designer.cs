namespace _4Rails_2
{
    partial class Modifycleaning
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Beschrijf = new System.Windows.Forms.Label();
            this.Date2 = new System.Windows.Forms.DateTimePicker();
            this.Date1 = new System.Windows.Forms.DateTimePicker();
            this.TijdEind = new System.Windows.Forms.Label();
            this.TijdStart = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.lblTramNR = new System.Windows.Forms.Label();
            this.Cbstatus = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Tramlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(141, 119);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 93);
            this.textBox1.TabIndex = 37;
            // 
            // Beschrijf
            // 
            this.Beschrijf.AutoSize = true;
            this.Beschrijf.Location = new System.Drawing.Point(9, 122);
            this.Beschrijf.Name = "Beschrijf";
            this.Beschrijf.Size = new System.Drawing.Size(64, 13);
            this.Beschrijf.TabIndex = 36;
            this.Beschrijf.Text = "Beschrijving";
            // 
            // Date2
            // 
            this.Date2.Location = new System.Drawing.Point(141, 93);
            this.Date2.Name = "Date2";
            this.Date2.Size = new System.Drawing.Size(200, 20);
            this.Date2.TabIndex = 35;
            // 
            // Date1
            // 
            this.Date1.Location = new System.Drawing.Point(141, 65);
            this.Date1.Name = "Date1";
            this.Date1.Size = new System.Drawing.Size(200, 20);
            this.Date1.TabIndex = 34;
            // 
            // TijdEind
            // 
            this.TijdEind.AutoSize = true;
            this.TijdEind.Location = new System.Drawing.Point(9, 99);
            this.TijdEind.Name = "TijdEind";
            this.TijdEind.Size = new System.Drawing.Size(57, 13);
            this.TijdEind.TabIndex = 33;
            this.TijdEind.Text = "DatumEnd";
            // 
            // TijdStart
            // 
            this.TijdStart.AutoSize = true;
            this.TijdStart.Location = new System.Drawing.Point(9, 71);
            this.TijdStart.Name = "TijdStart";
            this.TijdStart.Size = new System.Drawing.Size(60, 13);
            this.TijdStart.TabIndex = 32;
            this.TijdStart.Text = "DatumStart";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(9, 41);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(40, 13);
            this.Status.TabIndex = 31;
            this.Status.Text = "StaffID";
            // 
            // lblTramNR
            // 
            this.lblTramNR.AutoSize = true;
            this.lblTramNR.Location = new System.Drawing.Point(9, 13);
            this.lblTramNR.Name = "lblTramNR";
            this.lblTramNR.Size = new System.Drawing.Size(47, 13);
            this.lblTramNR.TabIndex = 30;
            this.lblTramNR.Text = "TramNR";
            // 
            // Cbstatus
            // 
            this.Cbstatus.FormattingEnabled = true;
            this.Cbstatus.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.Cbstatus.Location = new System.Drawing.Point(220, 38);
            this.Cbstatus.Name = "Cbstatus";
            this.Cbstatus.Size = new System.Drawing.Size(121, 21);
            this.Cbstatus.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(266, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Modify";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tramlbl
            // 
            this.Tramlbl.AutoSize = true;
            this.Tramlbl.Location = new System.Drawing.Point(220, 13);
            this.Tramlbl.Name = "Tramlbl";
            this.Tramlbl.Size = new System.Drawing.Size(35, 13);
            this.Tramlbl.TabIndex = 41;
            this.Tramlbl.Text = "label1";
            // 
            // Modifycleaning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 258);
            this.Controls.Add(this.Tramlbl);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Beschrijf);
            this.Controls.Add(this.Date2);
            this.Controls.Add(this.Date1);
            this.Controls.Add(this.TijdEind);
            this.Controls.Add(this.TijdStart);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.lblTramNR);
            this.Controls.Add(this.Cbstatus);
            this.Controls.Add(this.button1);
            this.Name = "Modifycleaning";
            this.Text = "Modifycleaning";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Beschrijf;
        private System.Windows.Forms.DateTimePicker Date2;
        private System.Windows.Forms.DateTimePicker Date1;
        private System.Windows.Forms.Label TijdEind;
        private System.Windows.Forms.Label TijdStart;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Label lblTramNR;
        private System.Windows.Forms.ComboBox Cbstatus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Tramlbl;
    }
}