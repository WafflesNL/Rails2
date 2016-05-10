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
            this.btnModify1 = new System.Windows.Forms.Button();
            this.Cbstatus = new System.Windows.Forms.ComboBox();
            this.BeheerTramNR = new System.Windows.Forms.Label();
            this.lblTramNR = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.RailNr = new System.Windows.Forms.Label();
            this.RailNRTxt = new System.Windows.Forms.Label();
            this.RailIDNew = new System.Windows.Forms.Label();
            this.SectorID = new System.Windows.Forms.Label();
            this.SectorIDlb = new System.Windows.Forms.Label();
            this.cbRailNr = new System.Windows.Forms.ComboBox();
            this.cbSectorNr = new System.Windows.Forms.ComboBox();
            this.btnModify2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnModify1
            // 
            this.btnModify1.Location = new System.Drawing.Point(271, 228);
            this.btnModify1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModify1.Name = "btnModify1";
            this.btnModify1.Size = new System.Drawing.Size(100, 28);
            this.btnModify1.TabIndex = 0;
            this.btnModify1.Text = "Modify";
            this.btnModify1.UseVisualStyleBackColor = true;
            this.btnModify1.Visible = false;
            this.btnModify1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cbstatus
            // 
            this.Cbstatus.FormattingEnabled = true;
            this.Cbstatus.Items.AddRange(new object[] {
            "Dienst",
            "Schoonmaak",
            "Defect",
            "Remise"});
            this.Cbstatus.Location = new System.Drawing.Point(211, 47);
            this.Cbstatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cbstatus.Name = "Cbstatus";
            this.Cbstatus.Size = new System.Drawing.Size(160, 24);
            this.Cbstatus.TabIndex = 2;
            this.Cbstatus.SelectedIndexChanged += new System.EventHandler(this.Cbstatus_SelectedIndexChanged);
            // 
            // BeheerTramNR
            // 
            this.BeheerTramNR.AutoSize = true;
            this.BeheerTramNR.Location = new System.Drawing.Point(21, 50);
            this.BeheerTramNR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BeheerTramNR.Name = "BeheerTramNR";
            this.BeheerTramNR.Size = new System.Drawing.Size(46, 17);
            this.BeheerTramNR.TabIndex = 3;
            this.BeheerTramNR.Text = "label1";
            // 
            // lblTramNR
            // 
            this.lblTramNR.AutoSize = true;
            this.lblTramNR.Location = new System.Drawing.Point(21, 16);
            this.lblTramNR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTramNR.Name = "lblTramNR";
            this.lblTramNR.Size = new System.Drawing.Size(61, 17);
            this.lblTramNR.TabIndex = 4;
            this.lblTramNR.Text = "TramNR";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(211, 15);
            this.Status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(48, 17);
            this.Status.TabIndex = 5;
            this.Status.Text = "Status";
            // 
            // RailNr
            // 
            this.RailNr.AutoSize = true;
            this.RailNr.Location = new System.Drawing.Point(21, 119);
            this.RailNr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RailNr.Name = "RailNr";
            this.RailNr.Size = new System.Drawing.Size(46, 17);
            this.RailNr.TabIndex = 6;
            this.RailNr.Text = "label1";
            // 
            // RailNRTxt
            // 
            this.RailNRTxt.AutoSize = true;
            this.RailNRTxt.Location = new System.Drawing.Point(21, 89);
            this.RailNRTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RailNRTxt.Name = "RailNRTxt";
            this.RailNRTxt.Size = new System.Drawing.Size(47, 17);
            this.RailNRTxt.TabIndex = 7;
            this.RailNRTxt.Text = "RailNr";
            // 
            // RailIDNew
            // 
            this.RailIDNew.AutoSize = true;
            this.RailIDNew.Location = new System.Drawing.Point(211, 89);
            this.RailIDNew.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RailIDNew.Name = "RailIDNew";
            this.RailIDNew.Size = new System.Drawing.Size(72, 17);
            this.RailIDNew.TabIndex = 8;
            this.RailIDNew.Text = "NewRailID";
            this.RailIDNew.Visible = false;
            // 
            // SectorID
            // 
            this.SectorID.AutoSize = true;
            this.SectorID.Location = new System.Drawing.Point(19, 155);
            this.SectorID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SectorID.Name = "SectorID";
            this.SectorID.Size = new System.Drawing.Size(62, 17);
            this.SectorID.TabIndex = 10;
            this.SectorID.Text = "SectorID";
            // 
            // SectorIDlb
            // 
            this.SectorIDlb.AutoSize = true;
            this.SectorIDlb.Location = new System.Drawing.Point(23, 190);
            this.SectorIDlb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SectorIDlb.Name = "SectorIDlb";
            this.SectorIDlb.Size = new System.Drawing.Size(46, 17);
            this.SectorIDlb.TabIndex = 11;
            this.SectorIDlb.Text = "label2";
            // 
            // cbRailNr
            // 
            this.cbRailNr.FormattingEnabled = true;
            this.cbRailNr.Items.AddRange(new object[] {
            "Dienst",
            "Schoonmaak",
            "Defect",
            "Remise"});
            this.cbRailNr.Location = new System.Drawing.Point(211, 119);
            this.cbRailNr.Margin = new System.Windows.Forms.Padding(4);
            this.cbRailNr.Name = "cbRailNr";
            this.cbRailNr.Size = new System.Drawing.Size(160, 24);
            this.cbRailNr.TabIndex = 12;
            this.cbRailNr.Visible = false;
            this.cbRailNr.SelectedIndexChanged += new System.EventHandler(this.cbRailNr_SelectedIndexChanged);
            // 
            // cbSectorNr
            // 
            this.cbSectorNr.FormattingEnabled = true;
            this.cbSectorNr.Items.AddRange(new object[] {
            "Dienst",
            "Schoonmaak",
            "Defect",
            "Remise"});
            this.cbSectorNr.Location = new System.Drawing.Point(211, 183);
            this.cbSectorNr.Margin = new System.Windows.Forms.Padding(4);
            this.cbSectorNr.Name = "cbSectorNr";
            this.cbSectorNr.Size = new System.Drawing.Size(160, 24);
            this.cbSectorNr.TabIndex = 13;
            this.cbSectorNr.Visible = false;
            // 
            // btnModify2
            // 
            this.btnModify2.Location = new System.Drawing.Point(271, 228);
            this.btnModify2.Margin = new System.Windows.Forms.Padding(4);
            this.btnModify2.Name = "btnModify2";
            this.btnModify2.Size = new System.Drawing.Size(100, 28);
            this.btnModify2.TabIndex = 14;
            this.btnModify2.Text = "Modify";
            this.btnModify2.UseVisualStyleBackColor = true;
            this.btnModify2.Visible = false;
            this.btnModify2.Click += new System.EventHandler(this.btnModify2_Click);
            // 
            // Tramspecificaties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 271);
            this.Controls.Add(this.btnModify2);
            this.Controls.Add(this.cbSectorNr);
            this.Controls.Add(this.cbRailNr);
            this.Controls.Add(this.SectorIDlb);
            this.Controls.Add(this.SectorID);
            this.Controls.Add(this.RailIDNew);
            this.Controls.Add(this.RailNRTxt);
            this.Controls.Add(this.RailNr);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.lblTramNR);
            this.Controls.Add(this.BeheerTramNR);
            this.Controls.Add(this.Cbstatus);
            this.Controls.Add(this.btnModify1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Tramspecificaties";
            this.Text = "Tramspecificaties";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModify1;
        private System.Windows.Forms.ComboBox Cbstatus;
        private System.Windows.Forms.Label BeheerTramNR;
        private System.Windows.Forms.Label lblTramNR;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Label RailNr;
        private System.Windows.Forms.Label RailNRTxt;
        private System.Windows.Forms.Label RailIDNew;
        private System.Windows.Forms.Label SectorID;
        private System.Windows.Forms.Label SectorIDlb;
        private System.Windows.Forms.ComboBox cbRailNr;
        private System.Windows.Forms.ComboBox cbSectorNr;
        private System.Windows.Forms.Button btnModify2;
    }
}