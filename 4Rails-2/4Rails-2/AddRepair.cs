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
    public partial class AddRepair : Form
    {
        Overview overview;
        public string tramnr;
        public string staffID;
        public string tijdstart;
        public string tijdeind;
        public string candrive;
        public string beschrijving;
        public int repairid;
        public AddRepair()
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
            repairid = Convert.ToInt32(overview.repairidstring) + 1;
            Cleanlbnew.Text = Convert.ToString(repairid);           
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
                    beschrijving = textBox1.Text;
                    if (checkBox1.Checked == true)
                    {
                        candrive = "Y";
                    }
                    else
                    {
                        candrive = "N";
                    }
                    overview.AddRepair(repairid, tramnr, staffID, tijdstart, tijdeind, candrive, beschrijving);
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
