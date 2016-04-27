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
        private RegelingClass rc;
        private List<string[]> regelinglist;

        public regelingGUI()
        {
            InitializeComponent();

            rc = new RegelingClass();
            regelinglist = rc.GetData();

            refreshForm();
        }

        private void refreshForm()
        {
            lbTramnr.Items.Clear();
            lbSpoor.Items.Clear();
            lbUser.Items.Clear();
            lbStatus.Items.Clear();
            foreach(string[] items in regelinglist)
            {
                lbTramnr.Items.Add(items[0]);
                lbSpoor.Items.Add(items[1]);
                lbUser.Items.Add(items[2]);
                lbStatus.Items.Add(items[3]);
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            string tramID = Convert.ToString(lbTramnr.SelectedItem);
            string where = Convert.ToString(lbTramnr.SelectedIndex);
            string status;
            string user;
            string spoor; 
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
                spoor = Convert.ToString(tbSpoor.Text);
            }
            else
            {
                spoor = Convert.ToString(lbSpoor.SelectedItem);
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
                tramID = Convert.ToString(tbTramnr.Text);
            }

            string sql = "UPDATE Tram SET Tramstatus =" + status + "WHERE Tram_ID =" + tramID;
            tbTramnr.Text = "";
            tbUser.Text = "";
            tbSpoor.Text = "";
            cbStatus.Text = "";

            //DataCom.nonQuery(sql);
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

        private void btnVoegtoe_Click(object sender, EventArgs e)
        {
            string tram = tbTramnr.Text;
            string spoor = tbSpoor.Text;
            string user = tbUser.Text;
            string status = cbStatus.Text;
            
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
