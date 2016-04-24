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
    public partial class Tramspecificaties : Form
    {
        public string status;
        public string tramnrs;
        Tramspecclass tramspec;
        public Tramspecificaties(string tramnr)
        {
            InitializeComponent();
            tramnrs = tramnr;
            BeheerTramNR.Text = tramnr;
            tramspec = new Tramspecclass();
            tramspec.onload(tramnrs);
            Cbstatus.Text = tramspec.tramclass;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            status = Cbstatus.Text;
            tramspec.modify(status, tramnrs);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
    }
}
