using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Introduction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            int sayi1 = int.Parse(txtSayi1.Text);
            int sayi2 = int.Parse(txtSayi2.Text);

            int toplam = sayi1 + sayi2;
            txtSonuc.Text = (toplam).ToString();
            MessageBox.Show(txtSonuc.Text);
        }

        private void btnTopla_MouseHover(object sender, EventArgs e)
        {
            btnTopla.BackColor = Color.Red;
        }

        private void btnTopla_MouseLeave(object sender, EventArgs e)
        {
            btnTopla.BackColor = Color.White;
        }
    }
}
