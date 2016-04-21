
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
    public partial class Login : Form
    {
        private string Username;
        private string Password;
        private bool Remember;
        LoginClass LC;

        public Login()
        {
            InitializeComponent();
            LC = new LoginClass();
        }

        

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Username = tbUsername.Text;
            Password = tbPassword.Text;

            int temp = Convert.ToInt16(LC.Check(Username, Password));

            if (temp != 0   )
            {
                switch (temp)
                {
                    case 1:
                        beheerGUI beheer = new beheerGUI();
                        this.Hide();
                        beheer.ShowDialog();
                        this.Close();
                        break;
                    case 2:
                        beheerGUI beheer2 = new beheerGUI();
                        this.Hide();
                        beheer2.ShowDialog();
                        this.Close();
                        break;
                    case 3:
                        regelingGUI regeling = new regelingGUI();
                        this.Hide();
                        regeling.ShowDialog();
                        this.Close();
                        break;
                    case 4:
                        customBox techniek = new customBox();
                        this.Hide();
                        techniek.ShowDialog();
                        this.Close();
                        break;
                    case 5:
                        customBox schoonmaak = new customBox();
                        this.Hide();
                        schoonmaak.ShowDialog();
                        this.Close();
                        break;
                }
            }
            else
            {
                tbUsername.Text = "rip";
            }
        }
    }
}
