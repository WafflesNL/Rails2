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
        nieuweTram nieuweTram;
        Overview overview;

        private string name;
        public string TramnrStringa;
        public string TramnrStringb;
        private int ID;
        public int i;
        public int j;
        public int Index;
        public beheerGUI(int id, string name)
        {
            InitializeComponent();
            nieuweTram = new nieuweTram();
            overview = new Overview();
            overview.Beheerlist();

            foreach (var items in overview.tramnrlist)
            {
                lbTramNr.Items.Add(items[0] + "                      " + items[1]);
            }
            this.ID = id;
            this.name = name;
            i = 0;
            j = 0;
            Index = 0;

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (this.lbTramNr.Items.Count > 0)
                {
                    if (i < 1)
                    {
                        lbTramNr.SetSelected(Index, true);
                        i++; 
                    }   
                }
            TramnrStringa = (string)lbTramNr.SelectedItem;
            TramnrStringb = TramnrStringa.Split(' ')[0];
            Tramnrlb.Text = TramnrStringb;
            lbTramNr.Refresh();
        }

        private void btnOpenSchoonmaak_Click(object sender, EventArgs e)
        {
            overview.CheckSchoonmaak();
            customBox.Show("Schoonmaakplanning", overview.data1);
        }

        private void btnOpenTechniek_Click(object sender, EventArgs e)
        {
            overview.CheckTechniek();
            customBox.Show("Techniekplanning", overview.data2);
        }

        private void btnTram_Click(object sender, EventArgs e)
        {
            Tramspecificaties tram = new Tramspecificaties(Tramnrlb.Text, overview.GetBeheerRails(Tramnrlb.Text), overview.GetBeheerSector(Tramnrlb.Text));
            tram.ShowDialog();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            mainWindow window = new mainWindow(ID, name);
            this.Close();
            this.Hide();
            window.ShowDialog();
        }

        private void btnNieuweTram_Click(object sender, EventArgs e)
        {
            nieuweTram.ShowDialog();
        }

        private void lbTramNr_MouseClick(object sender, MouseEventArgs e)
        {
            Index = (int)lbTramNr.SelectedIndex;
        }
    }
}
