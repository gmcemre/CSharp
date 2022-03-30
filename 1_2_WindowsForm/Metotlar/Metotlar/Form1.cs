using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             *Metotlar:
             *
             *İçerisine parametre alan , parametre almayan , geriye değer döndüren ve geriye değer döndürmeyen metotlar olarak metotlar birbirinden ayrışır.
             */
            UyariVer();

            decimal ttr = KdvHesapla(1500);
            MessageBox.Show(ttr.ToString());

            int Toplam = Toplama();
            MessageBox.Show(Toplam.ToString());

            decimal ttr2 = KdvHesapla(100, 0.15m);
        }
        //Void kelimesi bu metodun geriye hiçbirşey döndürmeyeceği anlamına gelir.
        //Metodun geriye döndürmeyen hali içerisindeki kodlar çalışır sonra biter.
        //İsmi uyarı ver olan parametre almayan geriye değer döndermeyen metottur.
        void UyariVer()
        {
            MessageBox.Show("Uyarı");
        }
        //Geriye değer döndürmeyen ve içine iki tane parametre alan metottur. 
        void Topla(int s1, int s2)
        {
            int topla = s1 + s2;
        }
        //İçerisine bir parametre alan ve geriye decimal tipinde değer döndüren metottur.
        decimal KdvHesapla(decimal fiyat)
        {
            decimal tutar = fiyat + (fiyat * 0.18m);
            //metot içerisinde geriye değer döndürme işlemini return komutu yapar.
            return tutar;
        }
        decimal KdvHesapla(decimal fiyat, decimal oran)
        {
            decimal tutar = fiyat + (fiyat * oran);
            return tutar;
        }
        //İçerisine parametre almayan ve geriye int tipinde değer döndüren metottur.
        int Toplama()
        {
            return 14 + 28;
        }

        /*
         * Metotların imzası vardır.Her metodun imzası bulunur.
         * Metodun imzasını içerisine aldığı parametre sayısı ve tipi belirler.
         * Aynı isimde metot oluşturmaya izin verilmezken aynı isimli metodun imzası değiştirilirse birden fazla çalışma yapısı kazandırılmış olur.
         * Metodun imzasını yani parametre sayısını ve tipini değiştirerek farklı çalışma yapısı kazandırma işine metot overload'u denir.
         */
    }
}
