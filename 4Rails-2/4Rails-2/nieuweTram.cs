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
        Trams trams;
        public nieuweTram()
        {
            InitializeComponent();
            
        }

        private void tbTramNR_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }

        private void btnBevestig_Click(object sender, EventArgs e)
        {

            int tramnr = Convert.ToInt32(tbTramNR.Text);
            foreach (Tram tram in trams.trams)
            {
                if(tramnr == tram.TramNR)
                {
                    MessageBox.Show("Tram bestaat al!");
                    return;
                }
            }
            btnBevestig.Visible = false;
            lblTramStatus.Visible = true;
            cbTramStatus.Visible = true;
        }
    }
}
