﻿namespace _4Rails_2
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
            this.lblGay.Location = new System.Drawing.Point(186, 140);
            this.lblGay.Name = "lblGay";
            this.lblGay.Size = new System.Drawing.Size(132, 17);
            this.lblGay.TabIndex = 0;
            this.lblGay.Text = "BART IS UBERGAY";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 387);
            this.Controls.Add(this.lblGay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGay;
    }
}

