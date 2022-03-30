using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogPencereleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFontDialog_Click(object sender, EventArgs e)
        {
            //Bütün dialog pencerelerinin Show veya ShowDialog isminde metotları bulunur.
            //Bu metotlar dialog pencerelerini açmaya yarar.
            DialogResult sonuc = fontDialog1.ShowDialog();
            //Tüm dialog pencereleri geriye DialogResult tipinde değer döndürür.
            //MessageBox.Show da yine bir dialog penceresidir.
            if (sonuc == DialogResult.OK)
            {
                //fontDialog1.Font özelliği içerisinde fontDialog penceresinden seçilen font değerleri tutulur.
                lblDenemeTahtasi.Font = fontDialog1.Font;
            }

        }

        private void btnOpenFileDialog_Click(object sender, EventArgs e)
        {
            //InitialDirectory özelliği varsayılan dosya konumunu açmayı sağlar.
            openFileDialog1.InitialDirectory = @"C:\Users\Lenovo\Desktop";

            //openFileDialog1.Filter = "Pdf Dosyası (*.pdf) | *.pdf | Jpeg Dosyası (*.jpeg) | *.jpeg | Png Dosyası (*.png) | (*.png) | Gif Dosyası (*.gif) | (*.gif) | Jpg Dosyası (*.jpg) | (*.jpg)";
            openFileDialog1.Filter = "Pdf Dosyası (*.pdf) | *.pdf";

            openFileDialog1.Title = "Resim Dosyası Seçiniz";
            //openFileDialog1.Filter = "Pdf Dosyası (*.pdf) | *.pdf";
            DialogResult sonuc = openFileDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                lblDenemeTahtasi.Text = openFileDialog1.FileName; // Dizin yolu ve Dosya isimi
                lblDeneme2.Text = openFileDialog1.SafeFileName; //Sadece dosya ismi
            }
        }

        private void btnSaveFileDialog_Click(object sender, EventArgs e)
        {
            //Dosya kaydetmemizi sağlayan dialog penceresi
            saveFileDialog1.Title = "Kaydedilecek Doysayı Seçiniz";
            DialogResult sonuc = saveFileDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                lblDenemeTahtasi.Text = saveFileDialog1.FileName;
            }
        }

        private void btnFolderBrowser_Click(object sender, EventArgs e)
        {
            //Klasör seçmemizi sağlayan dialog penceresi
            DialogResult sonuc = folderBrowserDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                lblDenemeTahtasi.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnColorDialog_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = colorDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                lblDenemeTahtasi.ForeColor = colorDialog1.Color;
                lblDeneme2.BackColor = colorDialog1.Color;
            }
        }
    }
}
