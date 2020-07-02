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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void buttonOrg_Click(object sender, EventArgs e)
        {
            Form formOrg = new FormOrg();
            formOrg.Show();
        }

        private void buttonGaz_Click(object sender, EventArgs e)
        {
            Form formGaz = new FormGaz();
            formGaz.Show();
        }

        private void buttonAds_Click(object sender, EventArgs e)
        {
            Form formAds = new FormAds();
            formAds.Show();
        }
    }
}
