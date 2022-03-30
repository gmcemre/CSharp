using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = txtIsim.Text;
            lvi.SubItems.Add(txtSoyisim.Text);
            string telefonNo = string.Format("{0} {1} {2}", comboBox1.Text, comboBox2.Text, mskdTelefon.Text);
            lvi.SubItems.Add(telefonNo);
            lvi.SubItems.Add(dtpDogumTarihi.Value.ToShortDateString());
            listView1.Items.Add(lvi);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }
    }
}
