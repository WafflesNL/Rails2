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

        public Login()
        {
            InitializeComponent();
            DataCom.ConnectToDB();
            //DataCom.nonQuery("INSERT INTO spoor (spoornr, blocked, aantalsectoren) VALUES (1, 0, 1)");
            string temp = DataCom.Read("SELECT spoornr FROM spoor WHERE spoornr = 1", "spoornr");
        }

        

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
