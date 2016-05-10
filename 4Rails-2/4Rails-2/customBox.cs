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
        Overview overview;
        public string Tramnrstringa;
        public string Tramnrstringb;
        public customBox()
        {
            overview = new Overview();
            InitializeComponent();
        }

        public static customBox planningBox; static DialogResult result = DialogResult.No;
        public static DialogResult Show(string Title, List<string[]> data)
        {
            planningBox = new customBox();
            planningBox.Text = Title;
            foreach (string[] items in data)
            {
                if (Title == "Schoonmaakplanning")
                {
                    planningBox.customlstBox.Items.Add(items[0] + "\t" + items[1] + "\t" + items[2] + "\t" + items[3] + "\t" + "  " + items[4]);
                }
                else
                {
                    planningBox.customlstBox.Items.Add(items[0] + "\t" + items[1] + "\t" + items[2] + "\t" + items[3] + "\t" + "  " + items[4] + "\t" + items[5]);
                }
            }            
            planningBox.ShowDialog();
            return result;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (planningBox.Text == "Schoonmaakplanning")
            {
                AddCleaning form = new AddCleaning();
                form.ShowDialog();
            }
            else
            {
                AddRepair form = new AddRepair();
                form.ShowDialog();
            }
        }

        private void Modify_Click(object sender, EventArgs e)
        {
            Tramnrstringa = (string)customlstBox.SelectedItem;
            Tramnrstringb = Tramnrstringa.Split('\t')[0];
            if (planningBox.Text == "Schoonmaakplanning")
            {
                Modifycleaning form = new Modifycleaning(Tramnrstringb);
                form.ShowDialog();
            }
            else
            {
                ModifyRepair form = new ModifyRepair(Tramnrstringb);
                form.ShowDialog();
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Tramnrstringa = (string)customlstBox.SelectedItem;
            Tramnrstringb = Tramnrstringa.Split('\t')[0];
            customlstBox.Items.Remove(customlstBox.SelectedItem);

            if (planningBox.Text == "Schoonmaakplanning")
            {
                overview.RemoveCleaning(Tramnrstringb);
            }
            else
            {
                overview.RemoveRepair(Tramnrstringb);
            }

        }
    }
}
