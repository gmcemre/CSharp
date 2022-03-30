using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listeleyiciler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtIsim.Text.Trim() != string.Empty)
            {
                string isim = string.Format("{0}-{1}", listKisiler.Items.Count + 1, txtIsim.Text.Trim());
                listKisiler.Items.Add(isim);
                //listKisiler.Items.Insert(0, isim);
                txtIsim.Clear();
                txtIsim.Focus();
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string[] silinecekler = new string[listKisiler.SelectedItems.Count];
            for (int i = 0; i < listKisiler.SelectedItems.Count; i++)
            {
                silinecekler[i] = listKisiler.SelectedItems[i].ToString();
            }
            foreach (string item in silinecekler)
            {
                listKisiler.Items.Remove(item);
            }
            //listKisiler.Items.Remove(listKisiler.SelectedItem);
        }

        private void listKisiler_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                string[] silinecekler = new string[listKisiler.SelectedItems.Count];
                for (int i = 0; i < listKisiler.SelectedItems.Count; i++)
                {
                    silinecekler[i] = listKisiler.SelectedItems[i].ToString();
                }
                foreach (string item in silinecekler)
                {
                    listKisiler.Items.Remove(item);
                }
            }
        }
    }
}
