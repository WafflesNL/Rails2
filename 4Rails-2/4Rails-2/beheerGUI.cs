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
        public beheerGUI()
        {
            InitializeComponent();
            schoonmaakplanning = new CleaningPlanning();
        }

        private void btnOpenSchoonmaak_Click(object sender, EventArgs e)
        {
            schoonmaakplanning.CheckSchoonmaak();
            customBox.Show("Schoonmaakplanning", schoonmaakplanning.data);
        }
    }
}
