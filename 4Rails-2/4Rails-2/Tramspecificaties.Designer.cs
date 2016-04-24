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
            this.button2 = new System.Windows.Forms.Button();
            this.Cbstatus = new System.Windows.Forms.ComboBox();
            this.BeheerTramNR = new System.Windows.Forms.Label();
            this.lblTramNR = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Modify";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(19, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // Tramspecificaties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 106);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.lblTramNR);
            this.Controls.Add(this.BeheerTramNR);
            this.Controls.Add(this.Cbstatus);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Tramspecificaties";
            this.Text = "Tramspecificaties";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox Cbstatus;
        private System.Windows.Forms.Label BeheerTramNR;
        private System.Windows.Forms.Label lblTramNR;
        private System.Windows.Forms.Label Status;
    }
}