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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // customlstBox
            // 
            this.customlstBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customlstBox.FormattingEnabled = true;
            this.customlstBox.ItemHeight = 20;
            this.customlstBox.Location = new System.Drawing.Point(12, 31);
            this.customlstBox.Name = "customlstBox";
            this.customlstBox.Size = new System.Drawing.Size(586, 444);
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
            this.Duurlabel.Location = new System.Drawing.Point(306, 9);
            this.Duurlabel.Name = "Duurlabel";
            this.Duurlabel.Size = new System.Drawing.Size(58, 13);
            this.Duurlabel.TabIndex = 7;
            this.Duurlabel.Text = "Datumeind";
            // 
            // Datumlabel
            // 
            this.Datumlabel.AutoSize = true;
            this.Datumlabel.Location = new System.Drawing.Point(160, 9);
            this.Datumlabel.Name = "Datumlabel";
            this.Datumlabel.Size = new System.Drawing.Size(58, 13);
            this.Datumlabel.TabIndex = 9;
            this.Datumlabel.Text = "Datumstart";
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
            this.Statuslabel.Location = new System.Drawing.Point(512, 9);
            this.Statuslabel.Name = "Statuslabel";
            this.Statuslabel.Size = new System.Drawing.Size(51, 13);
            this.Statuslabel.TabIndex = 11;
            this.Statuslabel.Text = "CanDrive";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(450, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Status";
            // 
            // customBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 482);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
    }
}