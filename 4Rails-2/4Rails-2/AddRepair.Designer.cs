namespace _4Rails_2
{
    partial class AddRepair
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
            this.Cleanlbnew = new System.Windows.Forms.Label();
            this.Repairlb = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Cleanlbnew
            // 
            this.Cleanlbnew.AutoSize = true;
            this.Cleanlbnew.Location = new System.Drawing.Point(226, 14);
            this.Cleanlbnew.Name = "Cleanlbnew";
            this.Cleanlbnew.Size = new System.Drawing.Size(34, 13);
            this.Cleanlbnew.TabIndex = 40;
            this.Cleanlbnew.Text = "Blank";
            // 
            // Repairlb
            // 
            this.Repairlb.AutoSize = true;
            this.Repairlb.Location = new System.Drawing.Point(15, 12);
            this.Repairlb.Name = "Repairlb";
            this.Repairlb.Size = new System.Drawing.Size(49, 13);
            this.Repairlb.TabIndex = 39;
            this.Repairlb.Text = "RepairID";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(226, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 38;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 181);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 93);
            this.textBox1.TabIndex = 37;
            // 
            // Beschrijf
            // 
            this.Beschrijf.AutoSize = true;
            this.Beschrijf.Location = new System.Drawing.Point(15, 184);
            this.Beschrijf.Name = "Beschrijf";
            this.Beschrijf.Size = new System.Drawing.Size(64, 13);
            this.Beschrijf.TabIndex = 36;
            this.Beschrijf.Text = "Beschrijving";
            // 
            // Date2
            // 
            this.Date2.Location = new System.Drawing.Point(147, 116);
            this.Date2.Name = "Date2";
            this.Date2.Size = new System.Drawing.Size(200, 20);
            this.Date2.TabIndex = 35;
            // 
            // Date1
            // 
            this.Date1.Location = new System.Drawing.Point(147, 88);
            this.Date1.Name = "Date1";
            this.Date1.Size = new System.Drawing.Size(200, 20);
            this.Date1.TabIndex = 34;
            // 
            // TijdEind
            // 
            this.TijdEind.AutoSize = true;
            this.TijdEind.Location = new System.Drawing.Point(15, 122);
            this.TijdEind.Name = "TijdEind";
            this.TijdEind.Size = new System.Drawing.Size(57, 13);
            this.TijdEind.TabIndex = 33;
            this.TijdEind.Text = "DatumEnd";
            // 
            // TijdStart
            // 
            this.TijdStart.AutoSize = true;
            this.TijdStart.Location = new System.Drawing.Point(15, 94);
            this.TijdStart.Name = "TijdStart";
            this.TijdStart.Size = new System.Drawing.Size(60, 13);
            this.TijdStart.TabIndex = 32;
            this.TijdStart.Text = "DatumStart";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(15, 64);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(40, 13);
            this.Status.TabIndex = 31;
            this.Status.Text = "StaffID";
            // 
            // lblTramNR
            // 
            this.lblTramNR.AutoSize = true;
            this.lblTramNR.Location = new System.Drawing.Point(15, 36);
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
            this.Cbstatus.Location = new System.Drawing.Point(226, 61);
            this.Cbstatus.Name = "Cbstatus";
            this.Cbstatus.Size = new System.Drawing.Size(121, 21);
            this.Cbstatus.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(272, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Modify";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "CanDrive";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(300, 152);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(44, 17);
            this.checkBox1.TabIndex = 42;
            this.checkBox1.Text = "Yes";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // AddRepair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 315);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cleanlbnew);
            this.Controls.Add(this.Repairlb);
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
            this.Name = "AddRepair";
            this.Text = "AddRepair";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Cleanlbnew;
        private System.Windows.Forms.Label Repairlb;
        private System.Windows.Forms.ComboBox comboBox1;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}