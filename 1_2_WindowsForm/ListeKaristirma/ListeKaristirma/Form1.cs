using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListeKaristirma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "*** LİSTE KARIŞTIRMA ***";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtIsim.Text.Trim() != "")
            {
                string isim = txtIsim.Text.Trim();
                if (!listIsim.Items.Contains(isim))
                {
                    listIsim.Items.Add(isim);
                }
                else
                {
                    MessageBox.Show("Eklemek istediğiniz kişi zaten mevcut!..Lütfen farklı bir isim giriniz.");
                }
                txtIsim.Clear();
                txtIsim.Focus();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Silmek istediğinize emin misiniz?", "Silme Formu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {
                string[] silinecekler = new string[listIsim.SelectedItems.Count];
                for (int i = 0; i < listIsim.SelectedItems.Count; i++)
                {
                    silinecekler[i] = listIsim.SelectedItems[i].ToString();
                }
                foreach (string item in silinecekler)
                {
                    listIsim.Items.Remove(item);
                }
            }
        }

        private void listIsim_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                string[] silinecekler = new string[listIsim.SelectedItems.Count];
                for (int i = 0; i < listIsim.SelectedItems.Count; i++)
                {
                    silinecekler[i] = listIsim.SelectedItems[i].ToString();
                }
                foreach (string item in silinecekler)
                {
                    listIsim.Items.Remove(item);
                }
            }
        }

        private void btnKaristir_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string[] karmaListe = new string[listIsim.Items.Count];

            for (int i = 0; i < listIsim.Items.Count; i++)
            {
                string isim = listIsim.Items[rnd.Next(listIsim.Items.Count)].ToString();
                if (karmaListe.Contains(isim))
                {
                    i--;
                }
                else
                {
                    karmaListe[i] = isim;
                }
            }
            listIsim.Items.Clear();
            foreach (string item in karmaListe)
            {
                listIsim.Items.Add(item);
            }
        }
    }
}
