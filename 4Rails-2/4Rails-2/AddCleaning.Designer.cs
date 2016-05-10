namespace _4Rails_2
{
    partial class AddCleaning
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
            this.Status = new System.Windows.Forms.Label();
            this.lblTramNR = new System.Windows.Forms.Label();
            this.Cbstatus = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TijdStart = new System.Windows.Forms.Label();
            this.TijdEind = new System.Windows.Forms.Label();
            this.Date1 = new System.Windows.Forms.DateTimePicker();
            this.Date2 = new System.Windows.Forms.DateTimePicker();
            this.Beschrijf = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Cleanlb = new System.Windows.Forms.Label();
            this.Cleanlbnew = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(18, 61);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(40, 13);
            this.Status.TabIndex = 17;
            this.Status.Text = "StaffID";
            // 
            // lblTramNR
            // 
            this.lblTramNR.AutoSize = true;
            this.lblTramNR.Location = new System.Drawing.Point(18, 33);
            this.lblTramNR.Name = "lblTramNR";
            this.lblTramNR.Size = new System.Drawing.Size(47, 13);
            this.lblTramNR.TabIndex = 16;
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
            this.Cbstatus.Location = new System.Drawing.Point(229, 58);
            this.Cbstatus.Name = "Cbstatus";
            this.Cbstatus.Size = new System.Drawing.Size(121, 21);
            this.Cbstatus.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Modify";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TijdStart
            // 
            this.TijdStart.AutoSize = true;
            this.TijdStart.Location = new System.Drawing.Point(18, 91);
            this.TijdStart.Name = "TijdStart";
            this.TijdStart.Size = new System.Drawing.Size(60, 13);
            this.TijdStart.TabIndex = 19;
            this.TijdStart.Text = "DatumStart";
            // 
            // TijdEind
            // 
            this.TijdEind.AutoSize = true;
            this.TijdEind.Location = new System.Drawing.Point(18, 119);
            this.TijdEind.Name = "TijdEind";
            this.TijdEind.Size = new System.Drawing.Size(57, 13);
            this.TijdEind.TabIndex = 20;
            this.TijdEind.Text = "DatumEnd";
            // 
            // Date1
            // 
            this.Date1.Location = new System.Drawing.Point(150, 85);
            this.Date1.Name = "Date1";
            this.Date1.Size = new System.Drawing.Size(200, 20);
            this.Date1.TabIndex = 21;
            // 
            // Date2
            // 
            this.Date2.Location = new System.Drawing.Point(150, 113);
            this.Date2.Name = "Date2";
            this.Date2.Size = new System.Drawing.Size(200, 20);
            this.Date2.TabIndex = 22;
            // 
            // Beschrijf
            // 
            this.Beschrijf.AutoSize = true;
            this.Beschrijf.Location = new System.Drawing.Point(18, 142);
            this.Beschrijf.Name = "Beschrijf";
            this.Beschrijf.Size = new System.Drawing.Size(64, 13);
            this.Beschrijf.TabIndex = 23;
            this.Beschrijf.Text = "Beschrijving";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 139);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 93);
            this.textBox1.TabIndex = 24;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(229, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 25;
            // 
            // Cleanlb
            // 
            this.Cleanlb.AutoSize = true;
            this.Cleanlb.Location = new System.Drawing.Point(18, 9);
            this.Cleanlb.Name = "Cleanlb";
            this.Cleanlb.Size = new System.Drawing.Size(45, 13);
            this.Cleanlb.TabIndex = 26;
            this.Cleanlb.Text = "CleanID";
            // 
            // Cleanlbnew
            // 
            this.Cleanlbnew.AutoSize = true;
            this.Cleanlbnew.Location = new System.Drawing.Point(229, 11);
            this.Cleanlbnew.Name = "Cleanlbnew";
            this.Cleanlbnew.Size = new System.Drawing.Size(34, 13);
            this.Cleanlbnew.TabIndex = 27;
            this.Cleanlbnew.Text = "Blank";
            // 
            // AddCleaning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 278);
            this.Controls.Add(this.Cleanlbnew);
            this.Controls.Add(this.Cleanlb);
            this.Controls.Add(this.comboBox1);
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
            this.Name = "AddCleaning";
            this.Text = "AddCleaning";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Label lblTramNR;
        private System.Windows.Forms.ComboBox Cbstatus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label TijdStart;
        private System.Windows.Forms.Label TijdEind;
        private System.Windows.Forms.DateTimePicker Date1;
        private System.Windows.Forms.DateTimePicker Date2;
        private System.Windows.Forms.Label Beschrijf;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Cleanlb;
        private System.Windows.Forms.Label Cleanlbnew;
    }
}