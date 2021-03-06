﻿using System;
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
    public partial class regelingGUI : Form
    {
        int regelingsNr;
        public Overview overview;
        Nieuwe_Regeling nieuweRegeling;

        private string name;
        private int ID;

        public regelingGUI(int id, string name)
        {

            InitializeComponent();
            overview = new Overview();
            overview.refreshRegulations();
            nieuweRegeling = new Nieuwe_Regeling();

            this.ID = id;
            this.name = name;
            
            refreshForm();
        }

        private void refreshForm()
        {

            lbRegelingen.Items.Clear();
            overview.refreshDatabase();
            foreach(Regulation regulation in overview.regulations)
            {
                
                lbRegelingen.Items.Add(regulation);
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nieuweRegeling.ShowDialog();
            refreshForm();
        }

        private void btnverwijder_Click(object sender, EventArgs e)
        {
            overview.removeRegulation(regelingsNr);
            refreshForm();
            
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            mainWindow mw = new mainWindow(ID, name);
            this.Hide();
            mw.ShowDialog();
            this.Close();
        }

        

        private void lbTramnr_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = Convert.ToString(lbRegelingen.SelectedItem);
            string deel = selected.Substring(0, 3);
            regelingsNr = Convert.ToInt32(deel);
            btnverwijder.Visible = true;

        }
         
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshForm();
        }
    }
}
