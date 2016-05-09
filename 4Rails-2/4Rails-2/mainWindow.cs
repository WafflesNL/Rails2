using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4Rails_2
{
    public partial class mainWindow : Form
    {
        private int ID;

        public mainWindow()
        {
            InitializeComponent();
            
        }

        public mainWindow(int id, string name)
        {
            InitializeComponent();
            Username.Text = name;
            this.ID = id;

            switch (ID)
            {
                case 1:
                    ToBeheerGUI.Enabled = true;
                    ToRegelingGUI.Enabled = true;
                    break;

                case 2:
                    ToBeheerGUI.Enabled = true;
                    ToRegelingGUI.Enabled = false;
                    break;

                case 3:
                    ToBeheerGUI.Enabled = true;
                    ToRegelingGUI.Enabled = false;
                    break;

                case 4:
                    ToBeheerGUI.Enabled = true;
                    ToRegelingGUI.Enabled = false;
                    break;

                case 5:
                    ToBeheerGUI.Enabled = false;
                    ToRegelingGUI.Enabled = true;
                    break;
            }
        }

        private void ToBeheerGUI_Click(object sender, EventArgs e)
        {
            beheerGUI myForm = new beheerGUI();
            this.Visible = false;
            myForm.ShowDialog();
            this.Close();
        }

        private void ToRegelingGUI_Click(object sender, EventArgs e)
        {
            regelingGUI myForm = new regelingGUI();
            this.Visible = false;
            myForm.ShowDialog();
            this.Close();
        }
    }
}
