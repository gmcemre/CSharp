using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RuntimeControlsIntroduction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sayac = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            Button button = new Button();
            Random rnd = new Random();
            button.Text = sayac.ToString();
            button.Width = 50;
            button.Height = 30;
            button.Left = rnd.Next(0, this.ClientSize.Width - button.Width);
            button.Top = rnd.Next(0, this.ClientSize.Height - button.Height);
            //Runtime anında üretilen bir control e event atama yöntemi += ile olur. += yazılır daha sonra iki kez tab tuşuna basılır.
            button.Click += Button_Click;
            this.Controls.Add(button);
            sayac++;
        }

        //object sender içerisinde Button_Click metodunu çalıştıran kontrol bulunur.
        private void Button_Click(object sender, EventArgs e)
        {
            //Tıklanan butonu yakalama yöntemi
            Button tiklanan = (Button)sender;
            //MessageBox.Show(tiklanan.Text);
            //this.Controls.Remove(tiklanan);
            tiklanan.BringToFront(); //en öne getirir.
            //tiklanan.SendToBack(); // en arkaya atar.
        }

        void ButtonOlustur(int satirSayisi)
        {
        yavaslat:
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button)
                {
                    this.Controls.Remove(ctrl);
                    goto yavaslat;
                }
            }
            //ilk döngü satır için işlem yapacak.
            for (int i = 0; i < satirSayisi; i++)
            {
                //İkinci döngümüzsütun için işlem yapacak
                for (int j = 0; j < 20; j++)
                {
                    Button btn = new Button();
                    btn.Width = 50;
                    btn.Height = 20;
                    btn.Text = String.Format("{0}x{1}", i + 1, j + 1);
                    btn.Left = j * 50;
                    btn.Top = i * 20 + 60;
                    this.Controls.Add(btn);
                }
            }
            this.Width = 50 * 21;
            this.Height = (satirSayisi * 20) + 100;
        }

        private void x20ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //10 satırlık 20 kolonluk bir buton koleksiyonu oluşturacağız.
            ButtonOlustur(10);
        }

        private void x20ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //20 satırlık 20 kolonluk bir buton koleksiyonu oluşturacağız.
            ButtonOlustur(20);
        }
    }
}
