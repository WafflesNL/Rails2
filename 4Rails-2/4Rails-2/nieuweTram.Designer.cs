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
            this.lblTramType = new System.Windows.Forms.Label();
            this.cbTramType = new System.Windows.Forms.ComboBox();
            this.btnBevestig = new System.Windows.Forms.Button();
            this.cbRailID = new System.Windows.Forms.ComboBox();
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
            this.lblRailID.Location = new System.Drawing.Point(38, 104);
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
            this.cbTramStatus.Location = new System.Drawing.Point(160, 61);
            this.cbTramStatus.Name = "cbTramStatus";
            this.cbTramStatus.Size = new System.Drawing.Size(208, 24);
            this.cbTramStatus.TabIndex = 5;
            this.cbTramStatus.Visible = false;
            // 
            // lblTramType
            // 
            this.lblTramType.AutoSize = true;
            this.lblTramType.Location = new System.Drawing.Point(38, 148);
            this.lblTramType.Name = "lblTramType";
            this.lblTramType.Size = new System.Drawing.Size(77, 17);
            this.lblTramType.TabIndex = 6;
            this.lblTramType.Text = "TramType:";
            this.lblTramType.Visible = false;
            // 
            // cbTramType
            // 
            this.cbTramType.FormattingEnabled = true;
            this.cbTramType.Location = new System.Drawing.Point(160, 145);
            this.cbTramType.Name = "cbTramType";
            this.cbTramType.Size = new System.Drawing.Size(208, 24);
            this.cbTramType.TabIndex = 7;
            this.cbTramType.Visible = false;
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
            // 
            // nieuweTram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 288);
            this.Controls.Add(this.cbRailID);
            this.Controls.Add(this.btnBevestig);
            this.Controls.Add(this.cbTramType);
            this.Controls.Add(this.lblTramType);
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
        private System.Windows.Forms.Label lblTramType;
        private System.Windows.Forms.ComboBox cbTramType;
        private System.Windows.Forms.Button btnBevestig;
        private System.Windows.Forms.ComboBox cbRailID;
    }
}