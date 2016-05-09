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
    public partial class beheerGUI : Form
    {
        CleaningPlanning schoonmaakplanning;
        techniekPlanning techniekplanning;
        nieuweTram nieuweTram;
        Overview overview;
        public beheerGUI()
        {
            InitializeComponent();
            schoonmaakplanning = new CleaningPlanning();
            techniekplanning = new techniekPlanning();
            nieuweTram = new nieuweTram();
            overview = new Overview();
            overview.Beheerlist();

            foreach (var items in overview.tramnrlist)
            {
                cbTramnr.Items.Add(items[0]);
                lbTramNr.Items.Add(items[0] + "                      " + items[1]);
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lbTramNr.Refresh();
        }

        private void btnOpenSchoonmaak_Click(object sender, EventArgs e)
        {
            overview.CheckSchoonmaak();
            customBox.Show("Schoonmaakplanning", overview.data1);
        }

        private void btnOpenTechniek_Click(object sender, EventArgs e)
        {
            techniekplanning.CheckTechniek();
            customBox.Show("Techniekplanning", overview.data2);
        }

        private void btnTram_Click(object sender, EventArgs e)
        {
            Tramspecificaties tram = new Tramspecificaties(cbTramnr.Text);
            tram.ShowDialog();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            mainWindow window = new mainWindow();
            this.Close();
            this.Hide();
            window.ShowDialog();
        }

        private void btnNieuweTram_Click(object sender, EventArgs e)
        {
            nieuweTram.ShowDialog();
        }
    }
}
