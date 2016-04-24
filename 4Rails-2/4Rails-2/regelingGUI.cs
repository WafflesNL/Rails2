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
            foreach(string[] items in regelinglist)
            {
                lbTramnr.Items.Add(items[0]);
                lbSpoor.Items.Add(items[1]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE regeling SET ?? WHERE ??";

            DataCom.nonQuery(sql);
        }

        private void btnverwijder_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM regeling WHERE ??";

            DataCom.nonQuery(sql);
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            mainWindow mw = new mainWindow();
            this.Hide();
            mw.ShowDialog();
            this.Close();
        }
    }
}
