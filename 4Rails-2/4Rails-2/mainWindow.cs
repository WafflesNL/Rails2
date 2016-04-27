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
        
        

        public mainWindow()
        {
            InitializeComponent();
            
            
            
        }

        public mainWindow(int id, string name)
        {
            InitializeComponent();
            Username.Text = name;
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
