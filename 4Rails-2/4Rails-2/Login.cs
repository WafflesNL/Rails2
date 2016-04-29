
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

            if (temp != 0)
            {
                mainWindow window = new mainWindow(temp, Username);
                this.Hide();
                window.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Gebruikersnaam en/of wachtwoord komen niet overeen.");
            }

        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
                e.Handled = true;
            }
        }

        private void tbUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
                e.Handled = true;
            }
        }
        
    }
}
