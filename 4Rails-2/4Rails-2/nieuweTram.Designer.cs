namespace _4Rails_2
{
    partial class nieuweTram
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
            this.lblTramNR = new System.Windows.Forms.Label();
            this.lblRailID = new System.Windows.Forms.Label();
            this.lblTramStatus = new System.Windows.Forms.Label();
            this.tbTramNR = new System.Windows.Forms.TextBox();
            this.cbTramStatus = new System.Windows.Forms.ComboBox();
            this.btnBevestig = new System.Windows.Forms.Button();
            this.cbRailID = new System.Windows.Forms.ComboBox();
            this.btnVoegToe = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblTramType = new System.Windows.Forms.Label();
            this.cbSector = new System.Windows.Forms.ComboBox();
            this.lblSector = new System.Windows.Forms.Label();
            this.lbRemise = new System.Windows.Forms.ListBox();
            this.cbRemiseNr = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTramNR
            // 
            this.lblTramNR.AutoSize = true;
            this.lblTramNR.Location = new System.Drawing.Point(38, 29);
            this.lblTramNR.Name = "lblTramNR";
            this.lblTramNR.Size = new System.Drawing.Size(65, 17);
            this.lblTramNR.TabIndex = 0;
            this.lblTramNR.Text = "TramNR:";
            // 
            // lblRailID
            // 
            this.lblRailID.AutoSize = true;
            this.lblRailID.Location = new System.Drawing.Point(41, 104);
            this.lblRailID.Name = "lblRailID";
            this.lblRailID.Size = new System.Drawing.Size(49, 17);
            this.lblRailID.TabIndex = 1;
            this.lblRailID.Text = "RailID:";
            this.lblRailID.Visible = false;
            // 
            // lblTramStatus
            // 
            this.lblTramStatus.AutoSize = true;
            this.lblTramStatus.Location = new System.Drawing.Point(38, 61);
            this.lblTramStatus.Name = "lblTramStatus";
            this.lblTramStatus.Size = new System.Drawing.Size(85, 17);
            this.lblTramStatus.TabIndex = 2;
            this.lblTramStatus.Text = "TramStatus:";
            this.lblTramStatus.Visible = false;
            // 
            // tbTramNR
            // 
            this.tbTramNR.Location = new System.Drawing.Point(160, 29);
            this.tbTramNR.Name = "tbTramNR";
            this.tbTramNR.Size = new System.Drawing.Size(208, 22);
            this.tbTramNR.TabIndex = 3;
            this.tbTramNR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTramNR_KeyPress);
            // 
            // cbTramStatus
            // 
            this.cbTramStatus.FormattingEnabled = true;
            this.cbTramStatus.Items.AddRange(new object[] {
            "Defect",
            "Schoonmaak",
            "Dienst",
            "Remise"});
            this.cbTramStatus.Location = new System.Drawing.Point(160, 61);
            this.cbTramStatus.Name = "cbTramStatus";
            this.cbTramStatus.Size = new System.Drawing.Size(208, 24);
            this.cbTramStatus.TabIndex = 5;
            this.cbTramStatus.Visible = false;
            this.cbTramStatus.SelectedIndexChanged += new System.EventHandler(this.cbTramStatus_SelectedIndexChanged);
            // 
            // btnBevestig
            // 
            this.btnBevestig.Location = new System.Drawing.Point(374, 20);
            this.btnBevestig.Name = "btnBevestig";
            this.btnBevestig.Size = new System.Drawing.Size(145, 34);
            this.btnBevestig.TabIndex = 8;
            this.btnBevestig.Text = "Bevestig";
            this.btnBevestig.UseVisualStyleBackColor = true;
            this.btnBevestig.Click += new System.EventHandler(this.btnBevestig_Click);
            // 
            // cbRailID
            // 
            this.cbRailID.FormattingEnabled = true;
            this.cbRailID.Location = new System.Drawing.Point(160, 101);
            this.cbRailID.Name = "cbRailID";
            this.cbRailID.Size = new System.Drawing.Size(208, 24);
            this.cbRailID.TabIndex = 9;
            this.cbRailID.Visible = false;
            this.cbRailID.SelectedIndexChanged += new System.EventHandler(this.cbRailID_SelectedIndexChanged);
            // 
            // btnVoegToe
            // 
            this.btnVoegToe.Location = new System.Drawing.Point(181, 243);
            this.btnVoegToe.Name = "btnVoegToe";
            this.btnVoegToe.Size = new System.Drawing.Size(145, 33);
            this.btnVoegToe.TabIndex = 10;
            this.btnVoegToe.Text = "Voeg Toe";
            this.btnVoegToe.UseVisualStyleBackColor = true;
            this.btnVoegToe.Visible = false;
            this.btnVoegToe.Click += new System.EventHandler(this.btnVoegToe_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(157, 164);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(208, 24);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.Visible = false;
            // 
            // lblTramType
            // 
            this.lblTramType.AutoSize = true;
            this.lblTramType.Location = new System.Drawing.Point(41, 167);
            this.lblTramType.Name = "lblTramType";
            this.lblTramType.Size = new System.Drawing.Size(77, 17);
            this.lblTramType.TabIndex = 12;
            this.lblTramType.Text = "TramType:";
            this.lblTramType.Visible = false;
            // 
            // cbSector
            // 
            this.cbSector.FormattingEnabled = true;
            this.cbSector.Location = new System.Drawing.Point(161, 132);
            this.cbSector.Name = "cbSector";
            this.cbSector.Size = new System.Drawing.Size(208, 24);
            this.cbSector.TabIndex = 13;
            this.cbSector.Visible = false;
            // 
            // lblSector
            // 
            this.lblSector.AutoSize = true;
            this.lblSector.Location = new System.Drawing.Point(41, 135);
            this.lblSector.Name = "lblSector";
            this.lblSector.Size = new System.Drawing.Size(66, 17);
            this.lblSector.TabIndex = 14;
            this.lblSector.Text = "SectorID:";
            this.lblSector.Visible = false;
            // 
            // lbRemise
            // 
            this.lbRemise.FormattingEnabled = true;
            this.lbRemise.ItemHeight = 16;
            this.lbRemise.Location = new System.Drawing.Point(561, 20);
            this.lbRemise.Name = "lbRemise";
            this.lbRemise.Size = new System.Drawing.Size(345, 228);
            this.lbRemise.TabIndex = 15;
            // 
            // cbRemiseNr
            // 
            this.cbRemiseNr.FormattingEnabled = true;
            this.cbRemiseNr.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbRemiseNr.Location = new System.Drawing.Point(675, 264);
            this.cbRemiseNr.Name = "cbRemiseNr";
            this.cbRemiseNr.Size = new System.Drawing.Size(230, 24);
            this.cbRemiseNr.TabIndex = 16;
            this.cbRemiseNr.SelectedIndexChanged += new System.EventHandler(this.cbRemiseNr_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(561, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "RemiseNr:";
            // 
            // nieuweTram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 323);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbRemiseNr);
            this.Controls.Add(this.lbRemise);
            this.Controls.Add(this.lblSector);
            this.Controls.Add(this.cbSector);
            this.Controls.Add(this.lblTramType);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnVoegToe);
            this.Controls.Add(this.cbRailID);
            this.Controls.Add(this.btnBevestig);
            this.Controls.Add(this.cbTramStatus);
            this.Controls.Add(this.tbTramNR);
            this.Controls.Add(this.lblTramStatus);
            this.Controls.Add(this.lblRailID);
            this.Controls.Add(this.lblTramNR);
            this.Name = "nieuweTram";
            this.Text = "nieuweTram";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTramNR;
        private System.Windows.Forms.Label lblRailID;
        private System.Windows.Forms.Label lblTramStatus;
        private System.Windows.Forms.TextBox tbTramNR;
        private System.Windows.Forms.ComboBox cbTramStatus;
        private System.Windows.Forms.Button btnBevestig;
        private System.Windows.Forms.ComboBox cbRailID;
        private System.Windows.Forms.Button btnVoegToe;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblTramType;
        private System.Windows.Forms.ComboBox cbSector;
        private System.Windows.Forms.Label lblSector;
        private System.Windows.Forms.ListBox lbRemise;
        private System.Windows.Forms.ComboBox cbRemiseNr;
        private System.Windows.Forms.Label label1;
    }
}