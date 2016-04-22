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

        static customBox MsgBox; static DialogResult result = DialogResult.No;
        public static DialogResult Show(string Title)
        {
            MsgBox = new customBox();
            MsgBox.Text = Title;
            MsgBox.ShowDialog();
            return result;
        }
    }
}
