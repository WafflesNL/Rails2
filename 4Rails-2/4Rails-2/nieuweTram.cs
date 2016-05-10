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
    public partial class nieuweTram: Form
    {
        public List<Sector> vrijeplaatsen;
        private int RemiseNr;

        Overview overview;
        public nieuweTram()
        {
            InitializeComponent();
            overview = new Overview();
            vrijeplaatsen = new List<Sector>();
            vrijeplaatsen.Clear();
            cbRemiseNr.Text = "1";
            refreshVrijeplaatsen();
        }

        static nieuweTram addTramBox;
        static DialogResult result = DialogResult.No;
        public static DialogResult Show(string Title, List<string[]> data)
        {
            addTramBox = new nieuweTram();
            addTramBox.Text = Title;
            
            addTramBox.ShowDialog();
            return result;
        }

        private void tbTramNR_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }

        private void btnBevestig_Click(object sender, EventArgs e)
        {
            int tramnr = Convert.ToInt32(tbTramNR.Text);
            foreach (Tram tram in overview.trams)
            {
                if (tramnr == tram.TramNR)
                {
                    MessageBox.Show("Tram bestaat al!");
                    return;
                }
            }
            btnBevestig.Visible = false;
            lblTramStatus.Visible = true;
            cbTramStatus.Visible = true;
        }

        private void cbTramStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblRailID.Visible = true;
            cbRailID.Visible = true;
            foreach (Spoor spoor in overview.rails )
            {
                cbRailID.Items.Add(spoor.Spoornummer);
            }
        }

       

        private void btnVoegToe_Click(object sender, EventArgs e)
        {
            int tramNr = Convert.ToInt32(tbTramNR.Text);
            int spoorNr = Convert.ToInt32(cbRailID.Text);
            int sectorNr = Convert.ToInt32(cbSector.Text);
            string tramStatus = cbTramStatus.Text;
            int bestemming = spoorNr;
            string trampType = cbTramType.Text;

            overview.newTram(tramNr, spoorNr, tramStatus, bestemming, trampType, sectorNr);
            this.Hide();
        }

        private void cbRailID_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSector.Visible = true;
            lblSector.Visible = true;
            cbSector.Items.Clear();
            cbSector.Text = "";
            int nummer = Convert.ToInt32(cbRailID.Text);
            foreach (Sector sector in overview.sectors)
            {
                if (sector.RailID == nummer)
                {
                    cbSector.Items.Add(sector.SectorNumber);
                }
            }
            
        }

        private void refreshVrijeplaatsen()
        {
            //Sector tempo = new Sector(0, 0);
            //int i = 0;
            //RemiseNr = Convert.ToInt32(cbRemiseNr.Text);
            //foreach (Sector sector in overview.sectors)
            //{
            //    if (sector.RailID == RemiseNr)
            //    {
            //        i = sector.SectorNumber;
            //        tempo = overview.checkVrij(RemiseNr, i);
            //        if (tempo.RailID > 0)
            //        {
            //            vrijeplaatsen.Add(tempo);
            //        }
            //    }
            //}

            //foreach(Sector vrij in vrijeplaatsen)
            //{
            //    lbRemise.Items.Add(vrij);
            //}

            
        }

        private void cbRemiseNr_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbSector_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbTramType.Visible = true;
            lblTramType.Visible = true;
        }

        private void cbTramType_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnVoegToe.Visible = true;
        }
    }
}
