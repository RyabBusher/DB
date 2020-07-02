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
    public partial class FormAds : Form
    {
        public FormAds()
        {
            InitializeComponent();
            ShowAds();
            ShowO();
            ShowG();
        }

        void ShowAds()
        {
            listViewAds.Items.Clear();
            foreach (AdsSet adsSet in Program.dailyDB.AdsSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    adsSet.ID.ToString(), adsSet.Num.ToString(), adsSet.Obem.ToString(),adsSet.IdOrg.ToString(),adsSet.IdGaz.ToString()
                });
                item.Tag = adsSet;
                listViewAds.Items.Add(item);
            }
            listViewAds.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        void ShowO()
        {
            comboBoxOrgId.Items.Clear();
            foreach(AdsSet adsSet in Program.dailyDB.AdsSet)
            {
                string[] item = {adsSet.ID.ToString() + ". ", "Наименование: " + adsSet.OrgSet.Name };
                comboBoxOrgId.Items.Add(string.Join(" ", item));
            }
        }

        void ShowG()
        {
            comboBoxGazId.Items.Clear();
            foreach (AdsSet adsSet in Program.dailyDB.AdsSet)
            {
                string[] item = {adsSet.ID.ToString() + ". ", "Наименование: " + adsSet.GazSet.Name };
                comboBoxGazId.Items.Add(string.Join(" ", item));
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AdsSet adsSet = new AdsSet();
            adsSet.Num = textBoxNum.Text;
            adsSet.Obem = textBoxObem.Text;
            adsSet.IdOrg = Convert.ToInt32(comboBoxOrgId.SelectedItem.ToString().Split('.')[0]);
            adsSet.IdGaz = Convert.ToInt32(comboBoxGazId.SelectedItem.ToString().Split('.')[0]);
            Program.dailyDB.AdsSet.Add(adsSet);
            Program.dailyDB.SaveChanges();
            ShowAds();
            ShowO();
            ShowG();
        }

        private void listViewGaz_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAds.SelectedItems.Count == 1)
            {
                AdsSet adsSet = listViewAds.SelectedItems[0].Tag as AdsSet;
                textBoxNum.Text = adsSet.Num;
                textBoxObem.Text = adsSet.Obem;
                comboBoxOrgId.SelectedIndex = comboBoxOrgId.FindString(adsSet.ID.ToString());
                comboBoxGazId.SelectedIndex = comboBoxGazId.FindString(adsSet.ID.ToString());
            }
            else
            {
                textBoxNum.Text = "";
                textBoxObem.Text = "";
                comboBoxOrgId.SelectedItem = null;
                comboBoxGazId.SelectedItem = null;
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewAds.SelectedItems.Count == 1)
            {
                AdsSet adsSet = listViewAds.SelectedItems[0].Tag as AdsSet;
                adsSet.Num = textBoxNum.Text;
                adsSet.Obem = textBoxObem.Text;
                adsSet.IdOrg = Convert.ToInt32(comboBoxOrgId.SelectedItem.ToString().Split('.')[0]);
                adsSet.IdGaz = Convert.ToInt32(comboBoxGazId.SelectedItem.ToString().Split('.')[0]);
                Program.dailyDB.SaveChanges();
                ShowAds();
                ShowO();
                ShowG();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewAds.SelectedItems.Count == 1)
                {
                    AdsSet adsSet = listViewAds.SelectedItems[0].Tag as AdsSet;
                    Program.dailyDB.AdsSet.Remove(adsSet);
                    Program.dailyDB.SaveChanges();
                    ShowAds();
                    ShowO();
                    ShowG();
                }
                textBoxNum.Text = "";
                textBoxObem.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, запись используется!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
