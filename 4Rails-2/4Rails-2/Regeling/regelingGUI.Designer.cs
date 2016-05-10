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
            this.lbRegelingen = new System.Windows.Forms.ListBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(18, 19);
            this.btnback.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(130, 41);
            this.btnback.TabIndex = 0;
            this.btnback.Text = "back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // tbTramnr
            // 
            this.tbTramnr.Location = new System.Drawing.Point(158, 94);
            this.tbTramnr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbTramnr.Multiline = true;
            this.tbTramnr.Name = "tbTramnr";
            this.tbTramnr.Size = new System.Drawing.Size(88, 35);
            this.tbTramnr.TabIndex = 6;
            // 
            // lblTramnr
            // 
            this.lblTramnr.AutoSize = true;
            this.lblTramnr.Location = new System.Drawing.Point(158, 56);
            this.lblTramnr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTramnr.Name = "lblTramnr";
            this.lblTramnr.Size = new System.Drawing.Size(80, 25);
            this.lblTramnr.TabIndex = 11;
            this.lblTramnr.Text = "Tramnr";
            // 
            // lblSpoor
            // 
            this.lblSpoor.AutoSize = true;
            this.lblSpoor.Location = new System.Drawing.Point(266, 56);
            this.lblSpoor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpoor.Name = "lblSpoor";
            this.lblSpoor.Size = new System.Drawing.Size(69, 25);
            this.lblSpoor.TabIndex = 12;
            this.lblSpoor.Text = "Spoor";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(442, 56);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(73, 25);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "Status";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(970, 6);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(268, 67);
            this.button2.TabIndex = 16;
            this.button2.Text = "Nieuwe Regeling";
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
            this.cbStatus.Location = new System.Drawing.Point(436, 94);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(148, 33);
            this.cbStatus.TabIndex = 17;
            // 
            // tbSpoor
            // 
            this.tbSpoor.Location = new System.Drawing.Point(248, 94);
            this.tbSpoor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSpoor.Multiline = true;
            this.tbSpoor.Name = "tbSpoor";
            this.tbSpoor.Size = new System.Drawing.Size(88, 35);
            this.tbSpoor.TabIndex = 7;
            // 
            // btnverwijder
            // 
            this.btnverwijder.Location = new System.Drawing.Point(970, 83);
            this.btnverwijder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnverwijder.Name = "btnverwijder";
            this.btnverwijder.Size = new System.Drawing.Size(268, 64);
            this.btnverwijder.TabIndex = 18;
            this.btnverwijder.Text = "Verwijder Regeling";
            this.btnverwijder.UseVisualStyleBackColor = true;
            this.btnverwijder.Click += new System.EventHandler(this.btnverwijder_Click);
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(338, 94);
            this.tbUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbUser.Multiline = true;
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(88, 35);
            this.tbUser.TabIndex = 20;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(344, 56);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(57, 25);
            this.lblUser.TabIndex = 21;
            this.lblUser.Text = "User";
            // 
            // lbRegelingen
            // 
            this.lbRegelingen.FormattingEnabled = true;
            this.lbRegelingen.ItemHeight = 25;
            this.lbRegelingen.Location = new System.Drawing.Point(158, 169);
            this.lbRegelingen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbRegelingen.Name = "lbRegelingen";
            this.lbRegelingen.Size = new System.Drawing.Size(781, 679);
            this.lbRegelingen.TabIndex = 1;
            this.lbRegelingen.SelectedIndexChanged += new System.EventHandler(this.lbTramnr_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(1134, 793);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(98, 55);
            this.btnRefresh.TabIndex = 22;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // regelingGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 895);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.btnverwijder);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblSpoor);
            this.Controls.Add(this.lblTramnr);
            this.Controls.Add(this.tbSpoor);
            this.Controls.Add(this.tbTramnr);
            this.Controls.Add(this.lbRegelingen);
            this.Controls.Add(this.btnback);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.ListBox lbRegelingen;
        private System.Windows.Forms.Button btnRefresh;
    }
}