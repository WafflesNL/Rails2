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
        public string RailNR;
        public string RailNewNR;
        Overview overview;
        beheerGUI beheer;
        public Tramspecificaties(string tramnr, string RailID)
        {
            InitializeComponent();
            tramnrs = tramnr;
            BeheerTramNR.Text = tramnr;
            RailNR = RailID;
            RailNr.Text = RailNR;
            overview = new Overview();
            overview.onload(tramnrs);
            Cbstatus.Text = overview.tramclass;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            status = Cbstatus.Text;
            RailNewNR = Convert.ToString(RailIDNum.Value);
            overview.modify(status, tramnrs, RailNR, RailNewNR);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
    }
}
