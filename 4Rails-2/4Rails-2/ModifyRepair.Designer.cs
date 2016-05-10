namespace _4Rails_2
{
    partial class ModifyRepair
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.Tramnrlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(299, 128);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(44, 17);
            this.checkBox1.TabIndex = 57;
            this.checkBox1.Text = "Yes";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "CanDrive";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(146, 157);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 93);
            this.textBox1.TabIndex = 52;
            // 
            // Beschrijf
            // 
            this.Beschrijf.AutoSize = true;
            this.Beschrijf.Location = new System.Drawing.Point(14, 160);
            this.Beschrijf.Name = "Beschrijf";
            this.Beschrijf.Size = new System.Drawing.Size(64, 13);
            this.Beschrijf.TabIndex = 51;
            this.Beschrijf.Text = "Beschrijving";
            // 
            // Date2
            // 
            this.Date2.Location = new System.Drawing.Point(146, 92);
            this.Date2.Name = "Date2";
            this.Date2.Size = new System.Drawing.Size(200, 20);
            this.Date2.TabIndex = 50;
            // 
            // Date1
            // 
            this.Date1.Location = new System.Drawing.Point(146, 64);
            this.Date1.Name = "Date1";
            this.Date1.Size = new System.Drawing.Size(200, 20);
            this.Date1.TabIndex = 49;
            // 
            // TijdEind
            // 
            this.TijdEind.AutoSize = true;
            this.TijdEind.Location = new System.Drawing.Point(14, 98);
            this.TijdEind.Name = "TijdEind";
            this.TijdEind.Size = new System.Drawing.Size(57, 13);
            this.TijdEind.TabIndex = 48;
            this.TijdEind.Text = "DatumEnd";
            // 
            // TijdStart
            // 
            this.TijdStart.AutoSize = true;
            this.TijdStart.Location = new System.Drawing.Point(14, 70);
            this.TijdStart.Name = "TijdStart";
            this.TijdStart.Size = new System.Drawing.Size(60, 13);
            this.TijdStart.TabIndex = 47;
            this.TijdStart.Text = "DatumStart";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(14, 40);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(40, 13);
            this.Status.TabIndex = 46;
            this.Status.Text = "StaffID";
            // 
            // lblTramNR
            // 
            this.lblTramNR.AutoSize = true;
            this.lblTramNR.Location = new System.Drawing.Point(14, 12);
            this.lblTramNR.Name = "lblTramNR";
            this.lblTramNR.Size = new System.Drawing.Size(47, 13);
            this.lblTramNR.TabIndex = 45;
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
            this.Cbstatus.Location = new System.Drawing.Point(225, 37);
            this.Cbstatus.Name = "Cbstatus";
            this.Cbstatus.Size = new System.Drawing.Size(121, 21);
            this.Cbstatus.TabIndex = 44;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 43;
            this.button1.Text = "Modify";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tramnrlbl
            // 
            this.Tramnrlbl.AutoSize = true;
            this.Tramnrlbl.Location = new System.Drawing.Point(225, 12);
            this.Tramnrlbl.Name = "Tramnrlbl";
            this.Tramnrlbl.Size = new System.Drawing.Size(34, 13);
            this.Tramnrlbl.TabIndex = 58;
            this.Tramnrlbl.Text = "Blank";
            // 
            // ModifyRepair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 285);
            this.Controls.Add(this.Tramnrlbl);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
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
            this.Name = "ModifyRepair";
            this.Text = "ModifyRepair";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Label Tramnrlbl;
    }
}