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
    public partial class customBox : Form
    {
        public customBox()
        {
            InitializeComponent();
        }

        static customBox planningBox; static DialogResult result = DialogResult.No;
        public static DialogResult Show(string Title, List<string[]> data)
        {
            planningBox = new customBox();
            planningBox.Text = Title;
            foreach (string[] items in data)
            {
                planningBox.customlstBox.Items.Add(items[0] + "\t" + items[1] + "\t" + items[2] + "\t" + items[3] + "\t" + items[4]);
            }            
            planningBox.ShowDialog();
            return result;
        }
    }
}
