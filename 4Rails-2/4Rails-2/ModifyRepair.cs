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
    public partial class ModifyRepair : Form
    {
        Overview overview;
        public string tramnr;
        public string staffID;
        public string tijdstart;
        public string tijdeind;
        public string candrive;
        public string beschrijving;
        public int repairid;
        public ModifyRepair(string tramnrs)
        {
            InitializeComponent();
            Date1.Format = DateTimePickerFormat.Custom;
            Date1.CustomFormat = "dd" + "-" + "MM" + "-" + "yyyy" + " " + "hh" + ":" + "mm" + ":" + "ss";
            Date2.Format = DateTimePickerFormat.Custom;
            Date2.CustomFormat = "dd" + "-" + "MM" + "-" + "yyyy" + " " + "hh" + ":" + "mm" + ":" + "ss";
            overview = new Overview();
            overview.Beheerlist();
            overview.CheckTechniek();
            overview.CheckRepair();
            Tramnrlbl.Text = tramnrs;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Cbstatus.Text != "" && Beschrijf.Text != "")
            {
                if (Cbstatus.Items.Contains(Cbstatus.Text))
                {
                    tramnr = Tramnrlbl.Text;
                    staffID = Cbstatus.Text;
                    tijdstart = Date1.Text;
                    tijdeind = Date2.Text;
                    beschrijving = textBox1.Text;
                    overview.modifyRepair(tramnr, staffID, tijdstart, tijdeind, beschrijving);
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
