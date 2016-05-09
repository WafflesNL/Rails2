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
        Overview overview;
        public Nieuwe_Regeling()
        {
            InitializeComponent();
            overview = new Overview();
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
            cbSpoorNr.Items.Clear();
            if (cbSoort.Text == "Dienst")
            {
                cbSpoorNr.Items.Add(6);
                cbSpoorNr.Items.Add(7);
                cbSpoorNr.Items.Add(8);
                cbSpoorNr.Items.Add(9);
                cbSpoorNr.Items.Add(10);
            }
            if(cbSoort.Text == "Techniek")
            {
                cbSpoorNr.Items.Add(5);
            }
            if(cbSoort.Text == "Schoonmaak")
            {
                cbSpoorNr.Items.Add(4);
            }
            if(cbSoort.Text == "Remise")
            {
                cbSpoorNr.Items.Add(1);
                cbSpoorNr.Items.Add(2);
                cbSpoorNr.Items.Add(3);
            }
        }
    }
}
