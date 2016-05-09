namespace _4Rails_2
{
    partial class Nieuwe_Regeling
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
            this.cbTramNR = new System.Windows.Forms.ComboBox();
            this.lblTramNummer = new System.Windows.Forms.Label();
            this.cbSoort = new System.Windows.Forms.ComboBox();
            this.lblSoort = new System.Windows.Forms.Label();
            this.cbSpoorNr = new System.Windows.Forms.ComboBox();
            this.lblSpoorNr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbTramNR
            // 
            this.cbTramNR.FormattingEnabled = true;
            this.cbTramNR.Location = new System.Drawing.Point(120, 21);
            this.cbTramNR.Name = "cbTramNR";
            this.cbTramNR.Size = new System.Drawing.Size(188, 24);
            this.cbTramNR.TabIndex = 0;
            this.cbTramNR.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // lblTramNummer
            // 
            this.lblTramNummer.AutoSize = true;
            this.lblTramNummer.Location = new System.Drawing.Point(12, 24);
            this.lblTramNummer.Name = "lblTramNummer";
            this.lblTramNummer.Size = new System.Drawing.Size(102, 17);
            this.lblTramNummer.TabIndex = 1;
            this.lblTramNummer.Text = "Tram Nummer:";
            // 
            // cbSoort
            // 
            this.cbSoort.FormattingEnabled = true;
            this.cbSoort.Items.AddRange(new object[] {
            "Dienst",
            "Schoonmaak",
            "Techniek",
            "Remise"});
            this.cbSoort.Location = new System.Drawing.Point(120, 51);
            this.cbSoort.Name = "cbSoort";
            this.cbSoort.Size = new System.Drawing.Size(188, 24);
            this.cbSoort.TabIndex = 2;
            this.cbSoort.SelectedIndexChanged += new System.EventHandler(this.cbSoort_SelectedIndexChanged);
            // 
            // lblSoort
            // 
            this.lblSoort.AutoSize = true;
            this.lblSoort.Location = new System.Drawing.Point(12, 54);
            this.lblSoort.Name = "lblSoort";
            this.lblSoort.Size = new System.Drawing.Size(106, 17);
            this.lblSoort.TabIndex = 3;
            this.lblSoort.Text = "Soort Regeling:";
            // 
            // cbSpoorNr
            // 
            this.cbSpoorNr.FormattingEnabled = true;
            this.cbSpoorNr.Items.AddRange(new object[] {
            "Dienst",
            "Schoonmaak",
            "Techniek",
            "Remise"});
            this.cbSpoorNr.Location = new System.Drawing.Point(120, 81);
            this.cbSpoorNr.Name = "cbSpoorNr";
            this.cbSpoorNr.Size = new System.Drawing.Size(188, 24);
            this.cbSpoorNr.TabIndex = 4;
            // 
            // lblSpoorNr
            // 
            this.lblSpoorNr.AutoSize = true;
            this.lblSpoorNr.Location = new System.Drawing.Point(15, 87);
            this.lblSpoorNr.Name = "lblSpoorNr";
            this.lblSpoorNr.Size = new System.Drawing.Size(65, 17);
            this.lblSpoorNr.TabIndex = 5;
            this.lblSpoorNr.Text = "SpoorNr:";
            // 
            // Nieuwe_Regeling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 282);
            this.Controls.Add(this.lblSpoorNr);
            this.Controls.Add(this.cbSpoorNr);
            this.Controls.Add(this.lblSoort);
            this.Controls.Add(this.cbSoort);
            this.Controls.Add(this.lblTramNummer);
            this.Controls.Add(this.cbTramNR);
            this.Name = "Nieuwe_Regeling";
            this.Text = "Nieuwe_Regeling";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTramNR;
        private System.Windows.Forms.Label lblTramNummer;
        private System.Windows.Forms.ComboBox cbSoort;
        private System.Windows.Forms.Label lblSoort;
        private System.Windows.Forms.ComboBox cbSpoorNr;
        private System.Windows.Forms.Label lblSpoorNr;
    }
}