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
        public string SectorNR;
        public string SectorNewNR;
        Overview overview;
        beheerGUI beheer;
        Login login;

        public Tramspecificaties(string tramnr, string RailID, string SectorID)
        {
            InitializeComponent();
            tramnrs = tramnr;
            BeheerTramNR.Text = tramnr;
            RailNR = RailID;
            RailNr.Text = RailNR;
            SectorNR = SectorID;
            SectorIDlb.Text = SectorNR;
            overview = new Overview();
            login = new Login();
            beheer = new beheerGUI(1,login.Username);
            overview.onload(tramnrs);
            Cbstatus.Text = overview.tramclass;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool vrijSpoor = false;
            foreach (Tram tram in overview.trams)
            {
                if (tram.HuidigSpoorNR == RailNewNR && tram.HuidigSectorNR == SectorNewNR)
                {
                    vrijSpoor = false;
                }
                else
                {
                    vrijSpoor = true;
                }
            }
            if (vrijSpoor == true)
            {
                //uitvoering
            }
            status = Cbstatus.Text;
            RailNewNR = Convert.ToString(RailIDNum.Value);
            SectorNewNR = Convert.ToString(SectorNum.Value);
            overview.modify(status, tramnrs, RailNR, RailNewNR, SectorNR, SectorNewNR);
            beheer.Beheerrefresh();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
    }
}
