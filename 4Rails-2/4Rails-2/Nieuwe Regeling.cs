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
    }
}
