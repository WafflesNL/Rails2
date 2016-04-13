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

            string temp = LC.Check(Username, Password);

            if (temp != null)
            {
                //change screen based on functie
                tbUsername.Text = "ok";
            }
            else
            {
                tbUsername.Text = "rip";
            }
        }
    }
}
