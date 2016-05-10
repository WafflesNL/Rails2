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
    public partial class AddCleaning : Form
    {
        Overview overview;
        public string tramnr;
        public string staffID;
        public string tijdstart;
        public string tijdeind;
        public string beschrijving;
        public int cleanid;
        public AddCleaning()
        {
            InitializeComponent();
            overview = new Overview();
            overview.Beheerlist();
            overview.CheckSchoonmaak();
            overview.CheckClean();
            cleanid = Convert.ToInt32(overview.cleanidstring) + 1;
            Cleanlbnew.Text = Convert.ToString(cleanid);
            foreach (var s in overview.tramnrlist)
            {
               comboBox1.Items.Add(s[0]);
            }           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && Cbstatus.Text != "" && Beschrijf.Text != "")
            {
                if (comboBox1.Items.Contains(comboBox1.Text) && Cbstatus.Items.Contains(Cbstatus.Text))
                {
                    tramnr = comboBox1.Text;
                    staffID = Cbstatus.Text;
                    tijdstart = Date1.Text;
                    tijdeind = Date2.Text;
                    beschrijving = Beschrijf.Text;
                    overview.AddCleaning(cleanid, tramnr, staffID, tijdstart, tijdeind, beschrijving);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Vul een geldige Tram in");
                }
            }
            else
            {
                MessageBox.Show("Vul alle velden in");
            }
        }
    }
}
