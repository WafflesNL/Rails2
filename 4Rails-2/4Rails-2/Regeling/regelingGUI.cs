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
    public partial class regelingGUI : Form
    {

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
            
            foreach(Regulation regulation in overview.regulations)
            {
                
                lbRegelingen.Items.Add(regulation);
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nieuweRegeling.ShowDialog();
        }

        private void btnverwijder_Click(object sender, EventArgs e)
        {
            string toDelete = Convert.ToString(lbRegelingen.SelectedItem);
            string sql = "DELETE FROM regulation WHERE Tram_ID ="+ toDelete;


            DataCom.nonQuery(sql);
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
            
          
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.refreshForm();
        }
    }
}
