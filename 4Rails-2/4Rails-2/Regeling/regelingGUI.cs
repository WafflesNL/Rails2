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

        public regelingGUI()
        {

            InitializeComponent();
            overview = new Overview();
            overview.refreshRegulations();
            
            refreshForm();
        }

        private void refreshForm()
        {
            lbTramnr.Items.Clear();
            lbSpoor.Items.Clear();
            lbUser.Items.Clear();
            lbStatus.Items.Clear();
            foreach(Regulation regulation in overview.regulations)
            {
                lbTramnr.Items.Add(regulation.tramNr);
                lbSpoor.Items.Add(regulation.spoorNr);
                lbUser.Items.Add(regulation.User);
                lbStatus.Items.Add(regulation.tramstatus);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            int tramID = Convert.ToInt32(lbTramnr.SelectedItem);
            string where = Convert.ToString(lbTramnr.SelectedIndex);
            string status;
            string user;
            int spoor; 
            if (cbStatus.Text != "")
            {
                status = Convert.ToString(cbStatus.Text);
            }
            else
            {
                status = Convert.ToString(lbStatus.SelectedItem);
            }  
            if (tbSpoor.Text != "")
            {
                spoor = Convert.ToInt32(tbSpoor.Text);
            }
            else
            {
                spoor = Convert.ToInt32(lbSpoor.SelectedItem);
            }
            if (tbUser.Text != "")
            {
                user = Convert.ToString(tbUser.Text);
            }
            else
            {
                user = Convert.ToString(lbUser.SelectedItem);
            }
            if (tbTramnr.Text != "")
            {
                tramID = Convert.ToInt32(tbTramnr.Text);
            }

            string sql = "UPDATE Tram SET Tramstatus =" + status + "WHERE Tram_ID =" + tramID;
            

            overview.newRegulation(tramID,spoor, user, status);
        }

        private void btnverwijder_Click(object sender, EventArgs e)
        {
            string toDelete = Convert.ToString(lbTramnr.SelectedItem);
            string sql = "DELETE FROM regulation WHERE Tram_ID ="+ toDelete;


            DataCom.nonQuery(sql);
            refreshForm();
            
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            mainWindow mw = new mainWindow();
            this.Hide();
            mw.ShowDialog();
            this.Close();
        }

        

        private void lbTramnr_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = Convert.ToInt32(lbTramnr.SelectedIndex);
            lbSpoor.SetSelected(selected, true);
            lbStatus.SetSelected(selected, true);
            lbUser.SetSelected(selected, true);
        }
    }
}
