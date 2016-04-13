namespace _4Rails_2
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
            this.lbTramStatus = new System.Windows.Forms.ListBox();
            this.btnOpenSchoonmaak = new System.Windows.Forms.Button();
            this.btnOpenTechniek = new System.Windows.Forms.Button();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.cbTramnr = new System.Windows.Forms.ComboBox();
            this.lbType = new System.Windows.Forms.ListBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTramNr
            // 
            this.lbTramNr.FormattingEnabled = true;
            this.lbTramNr.ItemHeight = 16;
            this.lbTramNr.Location = new System.Drawing.Point(12, 44);
            this.lbTramNr.Name = "lbTramNr";
            this.lbTramNr.Size = new System.Drawing.Size(214, 516);
            this.lbTramNr.TabIndex = 0;
            // 
            // lbTramStatus
            // 
            this.lbTramStatus.FormattingEnabled = true;
            this.lbTramStatus.ItemHeight = 16;
            this.lbTramStatus.Location = new System.Drawing.Point(247, 42);
            this.lbTramStatus.Name = "lbTramStatus";
            this.lbTramStatus.Size = new System.Drawing.Size(214, 516);
            this.lbTramStatus.TabIndex = 1;
            // 
            // btnOpenSchoonmaak
            // 
            this.btnOpenSchoonmaak.Location = new System.Drawing.Point(853, 514);
            this.btnOpenSchoonmaak.Name = "btnOpenSchoonmaak";
            this.btnOpenSchoonmaak.Size = new System.Drawing.Size(137, 46);
            this.btnOpenSchoonmaak.TabIndex = 2;
            this.btnOpenSchoonmaak.Text = "Open Schoonmaak";
            this.btnOpenSchoonmaak.UseVisualStyleBackColor = true;
            // 
            // btnOpenTechniek
            // 
            this.btnOpenTechniek.Location = new System.Drawing.Point(853, 462);
            this.btnOpenTechniek.Name = "btnOpenTechniek";
            this.btnOpenTechniek.Size = new System.Drawing.Size(137, 46);
            this.btnOpenTechniek.TabIndex = 3;
            this.btnOpenTechniek.Text = "Open Techniek";
            this.btnOpenTechniek.UseVisualStyleBackColor = true;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Schoonmaak",
            "Techniek",
            "Defect",
            "Dienst",
            "Remise"});
            this.cbStatus.Location = new System.Drawing.Point(247, 12);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(214, 24);
            this.cbStatus.TabIndex = 5;
            // 
            // cbTramnr
            // 
            this.cbTramnr.FormattingEnabled = true;
            this.cbTramnr.Location = new System.Drawing.Point(12, 12);
            this.cbTramnr.Name = "cbTramnr";
            this.cbTramnr.Size = new System.Drawing.Size(214, 24);
            this.cbTramnr.TabIndex = 6;
            // 
            // lbType
            // 
            this.lbType.FormattingEnabled = true;
            this.lbType.ItemHeight = 16;
            this.lbType.Location = new System.Drawing.Point(482, 44);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(214, 516);
            this.lbType.TabIndex = 7;
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(482, 14);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(214, 24);
            this.cbType.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(756, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Wählen Sie ein Auto zu Auswitch";
            // 
            // beheerGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_4Rails_2.Properties.Resources.beheerder;
            this.ClientSize = new System.Drawing.Size(1002, 568);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.cbTramnr);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.btnOpenTechniek);
            this.Controls.Add(this.btnOpenSchoonmaak);
            this.Controls.Add(this.lbTramStatus);
            this.Controls.Add(this.lbTramNr);
            this.Name = "beheerGUI";
            this.Text = "beheerGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbTramNr;
        private System.Windows.Forms.ListBox lbTramStatus;
        private System.Windows.Forms.Button btnOpenSchoonmaak;
        private System.Windows.Forms.Button btnOpenTechniek;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ComboBox cbTramnr;
        private System.Windows.Forms.ListBox lbType;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label label1;
    }
}