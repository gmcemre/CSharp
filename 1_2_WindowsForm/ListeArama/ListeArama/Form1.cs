using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListeArama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string isim = txtIsim.Text.Trim().ToUpper();
            if (isim != string.Empty)
            {
                if (!listIsim.Items.Contains(isim))
                {
                    listIsim.Items.Add(isim);
                }
                else
                {
                    MessageBox.Show("Girmiş olduğunuz isim listede mevcut.Farklı bir isim giriniz!!..");
                }
                txtIsim.Clear();
                txtIsim.Focus();
            }
        }

        private void btnKisiSayisi_Click(object sender, EventArgs e)
        {
            int kisiSayisi = listIsim.Items.Count;
            MessageBox.Show(string.Format("Toplam kişi sayısı : {0}", kisiSayisi));
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (txtIsimAra.Text != string.Empty)
            {
                string arananIsim = txtIsimAra.Text.Trim().ToUpper();
                if (listIsim.Items.Contains(arananIsim))
                {
                    MessageBox.Show("Aradığınız isim listede mevcut.");
                }
                else
                {
                    MessageBox.Show("Aradığınız isim listede yok!!..");
                }
            }
            else
            {
                MessageBox.Show("Lütfen listede aramak istediğiniz ismi giriniz.");
            }
            txtIsimAra.Clear();
        }

        //TODO:
        //txtIsimAra'da girilen her karakter için listIsim'de var olan isimler gözüksün silince isimler geri gelsin.Bu kısmı geliştir!!!.....

        /* 
           private void txtIsimAra_TextChanged(object sender, EventArgs e)
           {
               string aranan = txtIsimAra.Text.Trim().ToString();
               ArrayList isimler = new ArrayList();
               for (int i = 0; i < listIsim.Items.Count; i++)
               {
                   isimler.Add(listIsim.Items[i].ToString());
               }
               foreach (string item in isimler)
               {
                   if (!isimler.Contains(aranan))
                   {
                       listIsim.Items.Remove(item);
                   }
               }
           }
         */

    }
}
