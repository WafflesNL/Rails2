namespace _4Rails_2
{
    partial class regelingGUI
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
            this.btnback = new System.Windows.Forms.Button();
            this.tbTramnr = new System.Windows.Forms.TextBox();
            this.lblTramnr = new System.Windows.Forms.Label();
            this.lblSpoor = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.tbSpoor = new System.Windows.Forms.TextBox();
            this.btnverwijder = new System.Windows.Forms.Button();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lbTramnr = new System.Windows.Forms.ListBox();
            this.lbSpoor = new System.Windows.Forms.ListBox();
            this.lbStatus = new System.Windows.Forms.ListBox();
            this.lbUser = new System.Windows.Forms.ListBox();
            this.btnVoegtoe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(12, 12);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(87, 26);
            this.btnback.TabIndex = 0;
            this.btnback.Text = "back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // tbTramnr
            // 
            this.tbTramnr.Location = new System.Drawing.Point(105, 60);
            this.tbTramnr.Multiline = true;
            this.tbTramnr.Name = "tbTramnr";
            this.tbTramnr.Size = new System.Drawing.Size(60, 24);
            this.tbTramnr.TabIndex = 6;
            // 
            // lblTramnr
            // 
            this.lblTramnr.AutoSize = true;
            this.lblTramnr.Location = new System.Drawing.Point(105, 36);
            this.lblTramnr.Name = "lblTramnr";
            this.lblTramnr.Size = new System.Drawing.Size(54, 17);
            this.lblTramnr.TabIndex = 11;
            this.lblTramnr.Text = "Tramnr";
            // 
            // lblSpoor
            // 
            this.lblSpoor.AutoSize = true;
            this.lblSpoor.Location = new System.Drawing.Point(177, 36);
            this.lblSpoor.Name = "lblSpoor";
            this.lblSpoor.Size = new System.Drawing.Size(46, 17);
            this.lblSpoor.TabIndex = 12;
            this.lblSpoor.Text = "Spoor";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(295, 36);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(48, 17);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "Status";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(563, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 24);
            this.button2.TabIndex = 16;
            this.button2.Text = "bijwerken ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Remise ",
            "Dienst ",
            "Defect ",
            "Schoonmaak "});
            this.cbStatus.Location = new System.Drawing.Point(291, 60);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(100, 24);
            this.cbStatus.TabIndex = 17;
            // 
            // tbSpoor
            // 
            this.tbSpoor.Location = new System.Drawing.Point(165, 60);
            this.tbSpoor.Multiline = true;
            this.tbSpoor.Name = "tbSpoor";
            this.tbSpoor.Size = new System.Drawing.Size(60, 24);
            this.tbSpoor.TabIndex = 7;
            // 
            // btnverwijder
            // 
            this.btnverwijder.Location = new System.Drawing.Point(563, 108);
            this.btnverwijder.Name = "btnverwijder";
            this.btnverwijder.Size = new System.Drawing.Size(75, 26);
            this.btnverwijder.TabIndex = 18;
            this.btnverwijder.Text = "verwijderd";
            this.btnverwijder.UseVisualStyleBackColor = true;
            this.btnverwijder.Click += new System.EventHandler(this.btnverwijder_Click);
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(225, 60);
            this.tbUser.Multiline = true;
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(60, 24);
            this.tbUser.TabIndex = 20;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(229, 36);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(38, 17);
            this.lblUser.TabIndex = 21;
            this.lblUser.Text = "User";
            // 
            // lbTramnr
            // 
            this.lbTramnr.FormattingEnabled = true;
            this.lbTramnr.ItemHeight = 16;
            this.lbTramnr.Location = new System.Drawing.Point(105, 108);
            this.lbTramnr.Name = "lbTramnr";
            this.lbTramnr.Size = new System.Drawing.Size(60, 372);
            this.lbTramnr.TabIndex = 1;
            this.lbTramnr.SelectedIndexChanged += new System.EventHandler(this.lbTramnr_SelectedIndexChanged);
            // 
            // lbSpoor
            // 
            this.lbSpoor.FormattingEnabled = true;
            this.lbSpoor.ItemHeight = 16;
            this.lbSpoor.Location = new System.Drawing.Point(165, 108);
            this.lbSpoor.Name = "lbSpoor";
            this.lbSpoor.Size = new System.Drawing.Size(60, 372);
            this.lbSpoor.TabIndex = 2;
            
            // 
            // lbStatus
            // 
            this.lbStatus.FormattingEnabled = true;
            this.lbStatus.ItemHeight = 16;
            this.lbStatus.Location = new System.Drawing.Point(291, 108);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(100, 372);
            this.lbStatus.TabIndex = 3;
            
            // 
            // lbUser
            // 
            this.lbUser.FormattingEnabled = true;
            this.lbUser.ItemHeight = 16;
            this.lbUser.Location = new System.Drawing.Point(225, 108);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(60, 372);
            this.lbUser.TabIndex = 19;
            
            // 
            // btnVoegtoe
            // 
            this.btnVoegtoe.Location = new System.Drawing.Point(391, 60);
            this.btnVoegtoe.Name = "btnVoegtoe";
            this.btnVoegtoe.Size = new System.Drawing.Size(75, 24);
            this.btnVoegtoe.TabIndex = 22;
            this.btnVoegtoe.Text = "Voeg toe";
            this.btnVoegtoe.UseVisualStyleBackColor = true;
            this.btnVoegtoe.Click += new System.EventHandler(this.btnVoegtoe_Click);
            // 
            // regelingGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 492);
            this.Controls.Add(this.btnVoegtoe);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.btnverwijder);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblSpoor);
            this.Controls.Add(this.lblTramnr);
            this.Controls.Add(this.tbSpoor);
            this.Controls.Add(this.tbTramnr);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.lbSpoor);
            this.Controls.Add(this.lbTramnr);
            this.Controls.Add(this.btnback);
            this.Name = "regelingGUI";
            this.Text = "regelingGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.TextBox tbTramnr;
        private System.Windows.Forms.Label lblTramnr;
        private System.Windows.Forms.Label lblSpoor;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.TextBox tbSpoor;
        private System.Windows.Forms.Button btnverwijder;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.ListBox lbTramnr;
        private System.Windows.Forms.ListBox lbSpoor;
        private System.Windows.Forms.ListBox lbStatus;
        private System.Windows.Forms.ListBox lbUser;
        private System.Windows.Forms.Button btnVoegtoe;
    }
}