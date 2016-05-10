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
        public int Id;
        public string name;
        Overview overview;
        Login login;

        public Tramspecificaties(string tramnr, string RailID, string SectorID, int ID, string Name)
        {
            InitializeComponent();
            Id = ID;
            name = Name;
            tramnrs = tramnr;
            BeheerTramNR.Text = tramnr;
            RailNR = RailID;
            RailNr.Text = RailNR;
            SectorNR = SectorID;
            SectorIDlb.Text = SectorNR;
            overview = new Overview();
            login = new Login();
            overview.onload(tramnrs);
            Cbstatus.Text = overview.tramclass;

            switch (ID)
            {
                case 1:
                    Cbstatus.Enabled = true;
                    cbSectorNr.Enabled = true;
                    cbRailNr.Enabled = true;
                    break;

                case 2:
                    Cbstatus.Enabled = true;
                    cbSectorNr.Enabled = false;
                    cbRailNr.Enabled = false;
                    break;

                case 3:
                    Cbstatus.Enabled = true;
                    cbSectorNr.Enabled = false;
                    cbRailNr.Enabled = false;
                    break;

                case 4:
                    Cbstatus.Enabled = true;
                    cbSectorNr.Enabled = false;
                    cbRailNr.Enabled = false;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool vrijSpoor = false;
            status = Cbstatus.Text;

            RailNewNR = Convert.ToString(cbRailNr.Text);
            SectorNewNR = Convert.ToString(cbSectorNr.Text);
            int railnr = Convert.ToInt32(RailNewNR);
            int sectornr = Convert.ToInt32(SectorNewNR);
            Tram tram = overview.checkLocaties(railnr, sectornr);
            if (tram.HuidigSpoorNR == 0)
            {
                vrijSpoor = true;
            }
            if (vrijSpoor == true)
            {
                overview.modify(status, tramnrs, RailNR, RailNewNR, SectorNR, SectorNewNR);
                MessageBox.Show("Tram gewijzigd");
            }
            else
            {
                MessageBox.Show("Is bezet!");
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void Cbstatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbRailNr.Items.Clear();
            cbRailNr.Text = "";
            cbSectorNr.Items.Clear();
            cbSectorNr.Text = "";
            if(Cbstatus.Text == "Dienst")
            {
                cbRailNr.Items.Add(6);
                cbRailNr.Items.Add(7);
                cbRailNr.Items.Add(8);
                cbRailNr.Items.Add(9);
                cbRailNr.Items.Add(10);
            }
            if(Cbstatus.Text == "Schoonmaak")
            {
                cbRailNr.Items.Add(4);
            }
            if(Cbstatus.Text == "Defect")
            {
                cbRailNr.Items.Add(5);
            }
            if(Cbstatus.Text == "Remise")
            {
                cbRailNr.Items.Add(1);
                cbRailNr.Items.Add(2);
                cbRailNr.Items.Add(3);
            }
        }

        private void cbRailNr_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSectorNr.Items.Clear();
            cbSectorNr.Text = "";
            int nummer = Convert.ToInt32(cbRailNr.Text);
            foreach (Sector sector in overview.sectors)
            {
                if (sector.RailID == nummer)
                {
                    cbSectorNr.Items.Add(sector.SectorNumber);
                }
            }
        }

        private void btnModify2_Click(object sender, EventArgs e)
        {
            status = Cbstatus.Text;
            overview.modifyStatus(status, tramnrs);
        }
    }
}
