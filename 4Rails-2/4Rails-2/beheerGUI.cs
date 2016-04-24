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
        Beheerclass beheerclass;
        public beheerGUI()
        {
            InitializeComponent();
            schoonmaakplanning = new CleaningPlanning();
            techniekplanning = new techniekPlanning();
            beheerclass = new Beheerclass();
            foreach (var items in beheerclass.tramnrlist)
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
            schoonmaakplanning.CheckSchoonmaak();
            customBox.Show("Schoonmaakplanning", schoonmaakplanning.data);
        }

        private void btnOpenTechniek_Click(object sender, EventArgs e)
        {
            techniekplanning.CheckTechniek();
            customBox.Show("Techniekplanning", techniekplanning.data);
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
    }
}
