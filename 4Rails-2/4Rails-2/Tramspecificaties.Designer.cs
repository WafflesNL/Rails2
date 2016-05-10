namespace _4Rails_2
{
    partial class Tramspecificaties
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
            this.button1 = new System.Windows.Forms.Button();
            this.Cbstatus = new System.Windows.Forms.ComboBox();
            this.BeheerTramNR = new System.Windows.Forms.Label();
            this.lblTramNR = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.RailNr = new System.Windows.Forms.Label();
            this.RailNRTxt = new System.Windows.Forms.Label();
            this.RailIDNew = new System.Windows.Forms.Label();
            this.RailIDNum = new System.Windows.Forms.NumericUpDown();
            this.SectorID = new System.Windows.Forms.Label();
            this.SectorIDlb = new System.Windows.Forms.Label();
            this.SectorNum = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.RailIDNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SectorNum)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(203, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Modify";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cbstatus
            // 
            this.Cbstatus.FormattingEnabled = true;
            this.Cbstatus.Items.AddRange(new object[] {
            "Dienst",
            "Schoonmaak",
            "Defect",
            "Remise"});
            this.Cbstatus.Location = new System.Drawing.Point(158, 38);
            this.Cbstatus.Name = "Cbstatus";
            this.Cbstatus.Size = new System.Drawing.Size(121, 21);
            this.Cbstatus.TabIndex = 2;
            // 
            // BeheerTramNR
            // 
            this.BeheerTramNR.AutoSize = true;
            this.BeheerTramNR.Location = new System.Drawing.Point(16, 41);
            this.BeheerTramNR.Name = "BeheerTramNR";
            this.BeheerTramNR.Size = new System.Drawing.Size(35, 13);
            this.BeheerTramNR.TabIndex = 3;
            this.BeheerTramNR.Text = "label1";
            // 
            // lblTramNR
            // 
            this.lblTramNR.AutoSize = true;
            this.lblTramNR.Location = new System.Drawing.Point(16, 13);
            this.lblTramNR.Name = "lblTramNR";
            this.lblTramNR.Size = new System.Drawing.Size(47, 13);
            this.lblTramNR.TabIndex = 4;
            this.lblTramNR.Text = "TramNR";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(158, 12);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(37, 13);
            this.Status.TabIndex = 5;
            this.Status.Text = "Status";
            // 
            // RailNr
            // 
            this.RailNr.AutoSize = true;
            this.RailNr.Location = new System.Drawing.Point(16, 97);
            this.RailNr.Name = "RailNr";
            this.RailNr.Size = new System.Drawing.Size(35, 13);
            this.RailNr.TabIndex = 6;
            this.RailNr.Text = "label1";
            // 
            // RailNRTxt
            // 
            this.RailNRTxt.AutoSize = true;
            this.RailNRTxt.Location = new System.Drawing.Point(16, 72);
            this.RailNRTxt.Name = "RailNRTxt";
            this.RailNRTxt.Size = new System.Drawing.Size(36, 13);
            this.RailNRTxt.TabIndex = 7;
            this.RailNRTxt.Text = "RailNr";
            // 
            // RailIDNew
            // 
            this.RailIDNew.AutoSize = true;
            this.RailIDNew.Location = new System.Drawing.Point(158, 72);
            this.RailIDNew.Name = "RailIDNew";
            this.RailIDNew.Size = new System.Drawing.Size(58, 13);
            this.RailIDNew.TabIndex = 8;
            this.RailIDNew.Text = "NewRailID";
            // 
            // RailIDNum
            // 
            this.RailIDNum.Location = new System.Drawing.Point(158, 95);
            this.RailIDNum.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.RailIDNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RailIDNum.Name = "RailIDNum";
            this.RailIDNum.Size = new System.Drawing.Size(120, 20);
            this.RailIDNum.TabIndex = 9;
            this.RailIDNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SectorID
            // 
            this.SectorID.AutoSize = true;
            this.SectorID.Location = new System.Drawing.Point(14, 126);
            this.SectorID.Name = "SectorID";
            this.SectorID.Size = new System.Drawing.Size(49, 13);
            this.SectorID.TabIndex = 10;
            this.SectorID.Text = "SectorID";
            // 
            // SectorIDlb
            // 
            this.SectorIDlb.AutoSize = true;
            this.SectorIDlb.Location = new System.Drawing.Point(17, 154);
            this.SectorIDlb.Name = "SectorIDlb";
            this.SectorIDlb.Size = new System.Drawing.Size(35, 13);
            this.SectorIDlb.TabIndex = 11;
            this.SectorIDlb.Text = "label2";
            // 
            // SectorNum
            // 
            this.SectorNum.Location = new System.Drawing.Point(158, 147);
            this.SectorNum.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.SectorNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SectorNum.Name = "SectorNum";
            this.SectorNum.Size = new System.Drawing.Size(120, 20);
            this.SectorNum.TabIndex = 12;
            this.SectorNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Tramspecificaties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 220);
            this.Controls.Add(this.SectorNum);
            this.Controls.Add(this.SectorIDlb);
            this.Controls.Add(this.SectorID);
            this.Controls.Add(this.RailIDNum);
            this.Controls.Add(this.RailIDNew);
            this.Controls.Add(this.RailNRTxt);
            this.Controls.Add(this.RailNr);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.lblTramNR);
            this.Controls.Add(this.BeheerTramNR);
            this.Controls.Add(this.Cbstatus);
            this.Controls.Add(this.button1);
            this.Name = "Tramspecificaties";
            this.Text = "Tramspecificaties";
            ((System.ComponentModel.ISupportInitialize)(this.RailIDNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SectorNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox Cbstatus;
        private System.Windows.Forms.Label BeheerTramNR;
        private System.Windows.Forms.Label lblTramNR;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Label RailNr;
        private System.Windows.Forms.Label RailNRTxt;
        private System.Windows.Forms.Label RailIDNew;
        private System.Windows.Forms.NumericUpDown RailIDNum;
        private System.Windows.Forms.Label SectorID;
        private System.Windows.Forms.Label SectorIDlb;
        private System.Windows.Forms.NumericUpDown SectorNum;
    }
}