namespace _4Rails_2
{
    partial class mainWindow
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
            this.ToBeheerGUI = new System.Windows.Forms.Button();
            this.ToRegelingGUI = new System.Windows.Forms.Button();
            this.Welkomlabel = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ToBeheerGUI
            // 
            this.ToBeheerGUI.Location = new System.Drawing.Point(15, 37);
            this.ToBeheerGUI.Name = "ToBeheerGUI";
            this.ToBeheerGUI.Size = new System.Drawing.Size(140, 66);
            this.ToBeheerGUI.TabIndex = 0;
            this.ToBeheerGUI.Text = "Beheer";
            this.ToBeheerGUI.UseVisualStyleBackColor = true;
            this.ToBeheerGUI.Click += new System.EventHandler(this.ToBeheerGUI_Click);
            // 
            // ToRegelingGUI
            // 
            this.ToRegelingGUI.Location = new System.Drawing.Point(15, 109);
            this.ToRegelingGUI.Name = "ToRegelingGUI";
            this.ToRegelingGUI.Size = new System.Drawing.Size(140, 66);
            this.ToRegelingGUI.TabIndex = 1;
            this.ToRegelingGUI.Text = "Regeling";
            this.ToRegelingGUI.UseVisualStyleBackColor = true;
            this.ToRegelingGUI.Click += new System.EventHandler(this.ToRegelingGUI_Click);
            // 
            // Welkomlabel
            // 
            this.Welkomlabel.AutoSize = true;
            this.Welkomlabel.Location = new System.Drawing.Point(12, 12);
            this.Welkomlabel.Name = "Welkomlabel";
            this.Welkomlabel.Size = new System.Drawing.Size(49, 13);
            this.Welkomlabel.TabIndex = 2;
            this.Welkomlabel.Text = "Welkom,";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(59, 12);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(55, 13);
            this.Username.TabIndex = 3;
            this.Username.Text = "Naam hier";
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(170, 197);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Welkomlabel);
            this.Controls.Add(this.ToRegelingGUI);
            this.Controls.Add(this.ToBeheerGUI);
            this.Name = "mainWindow";
            this.Text = "mainWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ToBeheerGUI;
        private System.Windows.Forms.Button ToRegelingGUI;
        private System.Windows.Forms.Label Welkomlabel;
        private System.Windows.Forms.Label Username;
    }
}