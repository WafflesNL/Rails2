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
            this.SuspendLayout();
            // 
            // cbTramNR
            // 
            this.cbTramNR.FormattingEnabled = true;
            this.cbTramNR.Location = new System.Drawing.Point(313, 25);
            this.cbTramNR.Name = "cbTramNR";
            this.cbTramNR.Size = new System.Drawing.Size(121, 24);
            this.cbTramNR.TabIndex = 0;
            this.cbTramNR.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // Nieuwe_Regeling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 284);
            this.Controls.Add(this.cbTramNR);
            this.Name = "Nieuwe_Regeling";
            this.Text = "Nieuwe_Regeling";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTramNR;
    }
}