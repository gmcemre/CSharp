using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbIslem.SelectedIndex = 0;
        }

        private void btnSonuc_Click(object sender, EventArgs e)
        {
            decimal sayi1 = nudSayi1.Value;
            decimal sayi2 = nudSayi2.Value;
            decimal sonuc = 0;

            if (cmbIslem.Text == "/")
            {
                if (sayi2 == 0)
                {
                    MessageBox.Show("Bölen Sayı 0 olamaz!!..");
                    lblSonuc.Text = "Tanımsız";
                }
                else
                {
                    sonuc = sayi1 / sayi2;
                    lblSonuc.Text = sonuc.ToString();
                }
            }
            else
            {
                switch (cmbIslem.Text)
                {
                    case "+":
                        sonuc = sayi1 + sayi2;
                        break;
                    case "-":
                        sonuc = sayi1 - sayi2;
                        break;
                    case "*":
                        sonuc = sayi1 * sayi2;
                        break;
                    case "%":
                        if (sayi2 == 0)
                        {
                            MessageBox.Show("O 'a göre mod alınamaz!!..");
                        }
                        else
                        {
                            sonuc = sayi1 % sayi2;
                        }
                        break;
                    default:
                        break;
                }
                lblSonuc.Text = sonuc.ToString();
            }
        }
    }
}
