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
            this.button2 = new System.Windows.Forms.Button();
            this.btnverwijder = new System.Windows.Forms.Button();
            this.lbRegelingen = new System.Windows.Forms.ListBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblRegelingID = new System.Windows.Forms.Label();
            this.lblTramnr = new System.Windows.Forms.Label();
            this.lblSpoor = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1087, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 43);
            this.button2.TabIndex = 16;
            this.button2.Text = "Nieuwe Regeling";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnverwijder
            // 
            this.btnverwijder.Location = new System.Drawing.Point(1087, 61);
            this.btnverwijder.Name = "btnverwijder";
            this.btnverwijder.Size = new System.Drawing.Size(179, 41);
            this.btnverwijder.TabIndex = 18;
            this.btnverwijder.Text = "Verwijder Regeling";
            this.btnverwijder.UseVisualStyleBackColor = true;
            this.btnverwijder.Visible = false;
            this.btnverwijder.Click += new System.EventHandler(this.btnverwijder_Click);
            // 
            // lbRegelingen
            // 
            this.lbRegelingen.FormattingEnabled = true;
            this.lbRegelingen.ItemHeight = 16;
            this.lbRegelingen.Location = new System.Drawing.Point(105, 108);
            this.lbRegelingen.Name = "lbRegelingen";
            this.lbRegelingen.Size = new System.Drawing.Size(937, 436);
            this.lbRegelingen.TabIndex = 1;
            this.lbRegelingen.SelectedIndexChanged += new System.EventHandler(this.lbTramnr_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(1087, 513);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(179, 39);
            this.btnRefresh.TabIndex = 22;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblRegelingID
            // 
            this.lblRegelingID.AutoSize = true;
            this.lblRegelingID.Location = new System.Drawing.Point(105, 77);
            this.lblRegelingID.Name = "lblRegelingID";
            this.lblRegelingID.Size = new System.Drawing.Size(79, 17);
            this.lblRegelingID.TabIndex = 23;
            this.lblRegelingID.Text = "RegelingNr";
            // 
            // lblTramnr
            // 
            this.lblTramnr.AutoSize = true;
            this.lblTramnr.Location = new System.Drawing.Point(295, 77);
            this.lblTramnr.Name = "lblTramnr";
            this.lblTramnr.Size = new System.Drawing.Size(54, 17);
            this.lblTramnr.TabIndex = 11;
            this.lblTramnr.Text = "Tramnr";
            // 
            // lblSpoor
            // 
            this.lblSpoor.AutoSize = true;
            this.lblSpoor.Location = new System.Drawing.Point(486, 77);
            this.lblSpoor.Name = "lblSpoor";
            this.lblSpoor.Size = new System.Drawing.Size(46, 17);
            this.lblSpoor.TabIndex = 12;
            this.lblSpoor.Text = "Spoor";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(659, 77);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(38, 17);
            this.lblUser.TabIndex = 21;
            this.lblUser.Text = "User";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(925, 77);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(48, 17);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "Status";
            // 
            // regelingGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 573);
            this.Controls.Add(this.lblRegelingID);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnverwijder);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblSpoor);
            this.Controls.Add(this.lblTramnr);
            this.Controls.Add(this.lbRegelingen);
            this.Controls.Add(this.btnback);
            this.Name = "regelingGUI";
            this.Text = "regelingGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnverwijder;
        private System.Windows.Forms.ListBox lbRegelingen;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblRegelingID;
        private System.Windows.Forms.Label lblTramnr;
        private System.Windows.Forms.Label lblSpoor;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblStatus;
    }
}