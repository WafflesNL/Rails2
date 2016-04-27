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
        Overview overview;
        public nieuweTram()
        {
            InitializeComponent();
            overview = new Overview();
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
            int railNr = Convert.ToInt32(cbRailID.Text);
            string tramstatus = cbTramStatus.Text;
            int bestemming = railNr;
            overview.newTram(tramNr, railNr, tramstatus, bestemming);
        }

        private void cbRailID_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnVoegToe.Visible = true;
        }
    }
}
