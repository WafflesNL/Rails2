﻿namespace _4Rails_2
{
    partial class beheerGUI
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
            this.lbTramNr = new System.Windows.Forms.ListBox();
            this.btnOpenSchoonmaak = new System.Windows.Forms.Button();
            this.btnOpenTechniek = new System.Windows.Forms.Button();
            this.cbTramnr = new System.Windows.Forms.ComboBox();
            this.lbTram = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.btnTram = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTramNr
            // 
            this.lbTramNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTramNr.FormattingEnabled = true;
            this.lbTramNr.ItemHeight = 20;
            this.lbTramNr.Location = new System.Drawing.Point(9, 56);
            this.lbTramNr.Margin = new System.Windows.Forms.Padding(2);
            this.lbTramNr.Name = "lbTramNr";
            this.lbTramNr.Size = new System.Drawing.Size(338, 384);
            this.lbTramNr.TabIndex = 0;
            // 
            // btnOpenSchoonmaak
            // 
            this.btnOpenSchoonmaak.Location = new System.Drawing.Point(360, 54);
            this.btnOpenSchoonmaak.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenSchoonmaak.Name = "btnOpenSchoonmaak";
            this.btnOpenSchoonmaak.Size = new System.Drawing.Size(103, 37);
            this.btnOpenSchoonmaak.TabIndex = 2;
            this.btnOpenSchoonmaak.Text = "Open Schoonmaak";
            this.btnOpenSchoonmaak.UseVisualStyleBackColor = true;
            this.btnOpenSchoonmaak.Click += new System.EventHandler(this.btnOpenSchoonmaak_Click);
            // 
            // btnOpenTechniek
            // 
            this.btnOpenTechniek.Location = new System.Drawing.Point(360, 11);
            this.btnOpenTechniek.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenTechniek.Name = "btnOpenTechniek";
            this.btnOpenTechniek.Size = new System.Drawing.Size(103, 37);
            this.btnOpenTechniek.TabIndex = 3;
            this.btnOpenTechniek.Text = "Open Techniek";
            this.btnOpenTechniek.UseVisualStyleBackColor = true;
            this.btnOpenTechniek.Click += new System.EventHandler(this.btnOpenTechniek_Click);
            // 
            // cbTramnr
            // 
            this.cbTramnr.FormattingEnabled = true;
            this.cbTramnr.Location = new System.Drawing.Point(9, 10);
            this.cbTramnr.Margin = new System.Windows.Forms.Padding(2);
            this.cbTramnr.Name = "cbTramnr";
            this.cbTramnr.Size = new System.Drawing.Size(162, 21);
            this.cbTramnr.TabIndex = 6;
            // 
            // lbTram
            // 
            this.lbTram.AutoSize = true;
            this.lbTram.Location = new System.Drawing.Point(13, 38);
            this.lbTram.Name = "lbTram";
            this.lbTram.Size = new System.Drawing.Size(47, 13);
            this.lbTram.TabIndex = 7;
            this.lbTram.Text = "TramNR";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(133, 38);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(37, 13);
            this.lbStatus.TabIndex = 8;
            this.lbStatus.Text = "Status";
            // 
            // btnTram
            // 
            this.btnTram.Location = new System.Drawing.Point(193, 8);
            this.btnTram.Name = "btnTram";
            this.btnTram.Size = new System.Drawing.Size(75, 23);
            this.btnTram.TabIndex = 9;
            this.btnTram.Text = "Kies Tram";
            this.btnTram.UseVisualStyleBackColor = true;
            this.btnTram.Click += new System.EventHandler(this.btnTram_Click);
            // 
            // beheerGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 461);
            this.Controls.Add(this.btnTram);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.lbTram);
            this.Controls.Add(this.cbTramnr);
            this.Controls.Add(this.btnOpenTechniek);
            this.Controls.Add(this.btnOpenSchoonmaak);
            this.Controls.Add(this.lbTramNr);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "beheerGUI";
            this.Text = "beheerGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbTramNr;
        private System.Windows.Forms.Button btnOpenSchoonmaak;
        private System.Windows.Forms.Button btnOpenTechniek;
        private System.Windows.Forms.ComboBox cbTramnr;
        private System.Windows.Forms.Label lbTram;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Button btnTram;
    }
}