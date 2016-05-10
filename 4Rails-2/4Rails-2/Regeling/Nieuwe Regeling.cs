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
    public partial class Nieuwe_Regeling : Form
    {
        

        
        public Nieuwe_Regeling()
        {
            InitializeComponent();
            
            
            
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            foreach(Tram tram in overview.trams)
            {
                cbTramNR.Items.Add(tram.TramNR);
            }
        }

        private void cbSoort_SelectedIndexChanged(object sender, EventArgs e)
        {
            int functieID = 0;
            cbSpoorNr.Items.Clear();
            cbSpoorNr.Text = "";
            cbUser.Items.Clear();
            cbUser.Text = "";
            //cbSectorNummer.Items.Clear();
            //cbSectorNummer.Text = "";

            if (cbSoort.Text == "Dienst")
            {
                cbSpoorNr.Items.Add(6);
                cbSpoorNr.Items.Add(7);
                cbSpoorNr.Items.Add(8);
                cbSpoorNr.Items.Add(9);
                cbSpoorNr.Items.Add(10);
                functieID = 2;
            }
            if(cbSoort.Text == "Techniek")
            {
                cbSpoorNr.Items.Add(5);
                functieID = 4;
            }
            if(cbSoort.Text == "Schoonmaak")
            {
                cbSpoorNr.Items.Add(4);
                functieID = 3;
            }
            if(cbSoort.Text == "Remise")
            {
                cbSpoorNr.Items.Add(1);
                cbSpoorNr.Items.Add(2);
                cbSpoorNr.Items.Add(3);
                functieID = 5;
            }
            foreach(Gebruikers gebruiker in overview.gebruikers)
            {
                if(gebruiker.FunctieID == functieID)
                {
                    cbUser.Items.Add(gebruiker.Naam);
                }
            }
        }

        private void cbSpoorNr_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cbSectorNummer.Items.Clear();
            //int nummer = Convert.ToInt32(cbSpoorNr.Text);
            //foreach(Sector sector in overview.sectors)
            //{
            //    if(sector.RailID == nummer)
            //    {
            //        cbSectorNummer.Items.Add(sector.SectorNumber);
            //    }
            //}
        }

        private void btnBevestig_Click(object sender, EventArgs e)
        {
            int tramNr = Convert.ToInt32(cbTramNR.Text);
            string soort = cbSoort.Text;
            int railNr = Convert.ToInt32(cbSpoorNr.Text);
            string user = cbUser.Text;
            //int sectorNr = Convert.ToInt32(cbSectorNummer.Text);
            
            overview.newRegulation(tramNr, railNr, user, soort);
            cbTramNR.Items.Clear();
            cbTramNR.Text = "";
            cbSpoorNr.Items.Clear();
            cbSpoorNr.Text = "";
            cbSoort.Items.Clear();
            cbSoort.Text = "";
            cbUser.Items.Clear();
            cbUser.Text = "";
            refreshform()
            this.Hide();
            this.Close();
        }
    }
}
