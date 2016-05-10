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

        public string Name;
        public string TramnrStringa;
        public string TramnrStringb;
        public int ID;
        public int i;
        public int j;
        public int Index;
        public beheerGUI(int id, string name)
        {
            InitializeComponent();
            nieuweTram = new nieuweTram();
            overview = new Overview();
            
            Beheerrefresh();

            this.ID = id;
            this.Name = name;
            i = 0;
            j = 0;
            Index = 0;

            //Functions
            switch (ID)
            {
                case 1:
                    btnNieuweTram.Enabled = true;
                    btnTram.Enabled = true;
                    btnOpenSchoonmaak.Enabled = true;
                    btnOpenTechniek.Enabled = true;
                    break;

                case 2:
                    btnNieuweTram.Enabled = false;
                    btnTram.Enabled = true;
                    btnOpenSchoonmaak.Enabled = false;
                    btnOpenTechniek.Enabled = false;
                    break;

                case 3:
                    btnNieuweTram.Enabled = false;
                    btnTram.Enabled = true;
                    btnOpenSchoonmaak.Enabled = true;
                    btnOpenTechniek.Enabled = false;
                    break;

                case 4:
                    btnNieuweTram.Enabled = false;
                    btnTram.Enabled = true;
                    btnOpenSchoonmaak.Enabled = false;
                    btnOpenTechniek.Enabled = true;
                    break;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

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
            if (Tramnrlb.Text != "No Tram Selected")
            {
                Tramspecificaties tram = new Tramspecificaties(Tramnrlb.Text, overview.GetBeheerRails(Tramnrlb.Text), overview.GetBeheerSector(Tramnrlb.Text), ID, Name);
                tram.ShowDialog();
                Beheerrefresh();
            }
            else
            {
                MessageBox.Show("Select a Tram");
            }
            
        }

        private void Back_Click(object sender, EventArgs e)
        {
            mainWindow window = new mainWindow(ID, Name);
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

        private void lbTramNr_SelectedIndexChanged(object sender, EventArgs e)
        {
            TramnrStringa = (string)lbTramNr.SelectedItem;
            TramnrStringb = TramnrStringa.Split('\t')[0];
            Tramnrlb.Text = TramnrStringb;
        }

        public void Beheerrefresh()
        {
            overview.Beheerlist();
            lbTramNr.Items.Clear();          
            foreach (var items in overview.tramnrlist)
            {
                lbTramNr.Items.Add(items[0] + "\t\t" + items[1]);
            }
        }
    }
}
