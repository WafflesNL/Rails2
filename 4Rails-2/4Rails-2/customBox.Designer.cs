namespace _4Rails_2
{
    partial class customBox
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
            this.customlstBox = new System.Windows.Forms.ListBox();
            this.TramNRlabel = new System.Windows.Forms.Label();
            this.Duurlabel = new System.Windows.Forms.Label();
            this.Datumlabel = new System.Windows.Forms.Label();
            this.Personeelslabel = new System.Windows.Forms.Label();
            this.Statuslabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // customlstBox
            // 
            this.customlstBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customlstBox.FormattingEnabled = true;
            this.customlstBox.ItemHeight = 20;
            this.customlstBox.Location = new System.Drawing.Point(12, 31);
            this.customlstBox.Name = "customlstBox";
            this.customlstBox.Size = new System.Drawing.Size(503, 444);
            this.customlstBox.TabIndex = 0;
            // 
            // TramNRlabel
            // 
            this.TramNRlabel.AutoSize = true;
            this.TramNRlabel.Location = new System.Drawing.Point(9, 9);
            this.TramNRlabel.Name = "TramNRlabel";
            this.TramNRlabel.Size = new System.Drawing.Size(47, 13);
            this.TramNRlabel.TabIndex = 6;
            this.TramNRlabel.Text = "TramNR";
            // 
            // Duurlabel
            // 
            this.Duurlabel.AutoSize = true;
            this.Duurlabel.Location = new System.Drawing.Point(269, 9);
            this.Duurlabel.Name = "Duurlabel";
            this.Duurlabel.Size = new System.Drawing.Size(30, 13);
            this.Duurlabel.TabIndex = 7;
            this.Duurlabel.Text = "Duur";
            // 
            // Datumlabel
            // 
            this.Datumlabel.AutoSize = true;
            this.Datumlabel.Location = new System.Drawing.Point(126, 9);
            this.Datumlabel.Name = "Datumlabel";
            this.Datumlabel.Size = new System.Drawing.Size(38, 13);
            this.Datumlabel.TabIndex = 9;
            this.Datumlabel.Text = "Datum";
            // 
            // Personeelslabel
            // 
            this.Personeelslabel.AutoSize = true;
            this.Personeelslabel.Location = new System.Drawing.Point(62, 9);
            this.Personeelslabel.Name = "Personeelslabel";
            this.Personeelslabel.Size = new System.Drawing.Size(54, 13);
            this.Personeelslabel.TabIndex = 10;
            this.Personeelslabel.Text = "Personeel";
            // 
            // Statuslabel
            // 
            this.Statuslabel.AutoSize = true;
            this.Statuslabel.Location = new System.Drawing.Point(305, 9);
            this.Statuslabel.Name = "Statuslabel";
            this.Statuslabel.Size = new System.Drawing.Size(37, 13);
            this.Statuslabel.TabIndex = 11;
            this.Statuslabel.Text = "Status";
            // 
            // customBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 482);
            this.Controls.Add(this.Statuslabel);
            this.Controls.Add(this.Personeelslabel);
            this.Controls.Add(this.Datumlabel);
            this.Controls.Add(this.Duurlabel);
            this.Controls.Add(this.TramNRlabel);
            this.Controls.Add(this.customlstBox);
            this.Name = "customBox";
            this.Text = "customBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox customlstBox;
        private System.Windows.Forms.Label TramNRlabel;
        private System.Windows.Forms.Label Duurlabel;
        private System.Windows.Forms.Label Datumlabel;
        private System.Windows.Forms.Label Personeelslabel;
        private System.Windows.Forms.Label Statuslabel;
    }
}