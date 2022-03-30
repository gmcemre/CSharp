using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TcknDogrulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDogrula_Click(object sender, EventArgs e)
        {
            //if (mtbTckn.Text.Length == 11)
            if (mtbTckn.MaskFull)
            {
                int toplam = 0;
                for (int i = 0; i < mtbTckn.Text.Length - 1; i++)
                {
                    toplam += int.Parse(mtbTckn.Text[i].ToString());
                }
                if (!(toplam % 2 == 0))
                {
                    MessageBox.Show("Girmiş olduğunuz Tc Kimlik numarası kayıtlı değildir.Tekrar Deneyiniz!..");
                }
                else
                {
                    long tcSonBasamak = Convert.ToInt64(mtbTckn.Text) % 10;
                    //string sonBasamak = mtbTckn.Text[10].ToString();
                    //int tcSonBasamak = Convert.ToInt32(sonBasamak);
                    int toplamSonBasamak = toplam % 10;
                    if (tcSonBasamak == toplamSonBasamak)
                    {
                        MessageBox.Show("Girmiş olduğunuz TC kayıtlı.");
                    }
                    else
                    {
                        MessageBox.Show("Girmiş olduğunuz Tc Kimlik numarası kayıtlı değildir.Tekrar Deneyiniz!..");
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen 11 Haneli Bir TCKN Giriniz!..");
            }

            mtbTckn.Clear();
        }
    }
}
