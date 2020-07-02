using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daily_Bugle
{
    public partial class FormGaz : Form
    {
        public FormGaz()
        {
            InitializeComponent();
        }

        void ShowGaz()
        {
            listViewGaz.Items.Clear();
            foreach (GazSet gazSet in Program.dailyDB.GazSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    gazSet.ID.ToString(),gazSet.Name.ToString(),gazSet.Price.ToString(),gazSet.Phone.ToString()
                });
                item.Tag = gazSet;
                listViewGaz.Items.Add(item);
            }
            listViewGaz.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void listViewGaz_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewGaz.SelectedItems.Count == 1)
            {
                GazSet gazSet = listViewGaz.SelectedItems[0].Tag as GazSet;
                textBoxName.Text = gazSet.Name;
                textBoxPrice.Text = gazSet.Price;
                textBoxPhone.Text = gazSet.Phone;
            }
            else
            {
                textBoxName.Text = "";
                textBoxPrice.Text = "";
                textBoxPhone.Text = "";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            GazSet gazSet = new GazSet();
            gazSet.Name = textBoxName.Text;
            gazSet.Phone = textBoxPhone.Text;
            gazSet.Price = textBoxPrice.Text;
            Program.dailyDB.GazSet.Add(gazSet);
            Program.dailyDB.SaveChanges();
            ShowGaz();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewGaz.SelectedItems.Count == 1)
            {
                GazSet gazSet = listViewGaz.SelectedItems[0].Tag as GazSet;
                gazSet.Name = textBoxName.Text;
                gazSet.Price = textBoxPrice.Text;
                gazSet.Phone = textBoxPhone.Text;
                Program.dailyDB.SaveChanges();
                ShowGaz();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewGaz.SelectedItems.Count == 1)
                {
                    GazSet gazSet = listViewGaz.SelectedItems[0].Tag as GazSet;
                    Program.dailyDB.GazSet.Remove(gazSet);
                    Program.dailyDB.SaveChanges();
                    ShowGaz();
                }
                textBoxName.Text = "";
                textBoxPrice.Text = "";
                textBoxPhone.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
