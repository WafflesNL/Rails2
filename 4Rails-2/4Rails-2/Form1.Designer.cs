namespace _4Rails_2
{
    partial class Form1
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
            this.lblGay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGay
            // 
            this.lblGay.AutoSize = true;
            this.lblGay.Location = new System.Drawing.Point(140, 114);
            this.lblGay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGay.Name = "lblGay";
            this.lblGay.Size = new System.Drawing.Size(179, 13);
            this.lblGay.TabIndex = 0;
            this.lblGay.Text = "Kevin houdt van Piemels in zijn anus";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 314);
            this.Controls.Add(this.lblGay);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGay;
    }
}

