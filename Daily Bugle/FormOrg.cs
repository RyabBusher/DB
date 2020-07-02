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
    public partial class FormOrg : Form
    {
        public FormOrg()
        {
            InitializeComponent();
            ShowOrg();
        }

        void ShowOrg()
        {
            listViewOrg.Items.Clear();
            foreach(OrgSet orgSet in Program.dailyDB.OrgSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    orgSet.ID.ToString(),orgSet.Name.ToString(),orgSet.Adress.ToString(),orgSet.Phone.ToString()
                });
                item.Tag = orgSet;
                    listViewOrg.Items.Add(item);
            }
            listViewOrg.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrgSet orgSet = new OrgSet();
            orgSet.Name = textBoxName.Text;
            orgSet.Adress = textBoxAdress.Text;
            orgSet.Phone = textBoxPhone.Text;
            Program.dailyDB.OrgSet.Add(orgSet);
            Program.dailyDB.SaveChanges();
            ShowOrg();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listViewOrg.SelectedItems.Count == 1)
            {
                OrgSet orgSet = listViewOrg.SelectedItems[0].Tag as OrgSet;
                orgSet.Name = textBoxName.Text;
                orgSet.Adress = textBoxAdress.Text;
                orgSet.Phone = textBoxPhone.Text;
                Program.dailyDB.SaveChanges();
                ShowOrg();
            }
        }

        private void listViewOrg_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewOrg.SelectedItems.Count == 1)
            {
                OrgSet orgSet = listViewOrg.SelectedItems[0].Tag as OrgSet;
                textBoxName.Text = orgSet.Name;
                textBoxAdress.Text = orgSet.Adress;
                textBoxPhone.Text = orgSet.Phone;
            }
            else
            {
                textBoxName.Text = "";
                textBoxAdress.Text = "";
                textBoxPhone.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewOrg.SelectedItems.Count == 1)
                {
                    OrgSet orgSet = listViewOrg.SelectedItems[0].Tag as OrgSet;
                    Program.dailyDB.OrgSet.Remove(orgSet);
                    Program.dailyDB.SaveChanges();
                    ShowOrg();
                }
                textBoxName.Text = "";
                textBoxAdress.Text = "";
                textBoxPhone.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
