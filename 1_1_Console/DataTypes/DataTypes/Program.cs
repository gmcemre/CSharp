using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Veri Tipleri:
             * 
             * 1-Tamsayı Tipleri:İçerisinde sadece tamsayı barındıran tiplerdir.
             * 1.1-byte:
             * -0-255 arasında değer tutar.
             * -En küçük tamsayı tipidir.
             * -Ram'da 1 byte'lık yer kaplar.
             * 
             * 1.2-sbyte:
             * -  -128 ile +127 arasında değer tutar.
             * 
             * 1.3-short:
             * -  -32768 ile +32767 arasında değer tutar.
             * -Ram'da 2 byte'lık yer kaplar.
             * 
             * 1.4-ushort:
             * - 0 ile 65535 arasında değer tutar.
             * 
             * 1.5-int:
             * -Varsayılan tamsayı tiptir.
             * - -1.14 milyar ile +1.14 milyar arasında değer tutar.
             * -Ram'da 4 byte'lık yer tutar.
             * 1.6-uint:
             * -  0 ile 2.28 milyar arasında değer tutar.
             * 
             * 1.7- long:
             * -Tamsayı tiplerinin en büyüğüdür.
             * -Ram da 8 byte lık yer kaplar.
             * - -çok ile +çok arasında değer tutar.
             * 
             * 1.8-ulong:
             * - 0 ile +çok arasında değer tutar.
             * 
             * 2-Ondalıklı Veri Tipleri:
             * 
             * 2.1-float:
             * -Uzunluk , ölçü birimlerinde kullanılır.
             * -En küçük ondalıklı tiptir.
             * 
             * 2.2-double:
             * -Varsayılan ondalıklı tiptir.
             * -Matematiksel işlemlerde kullanılır.
             * 
             * 2.3-decimal:
             * -Ondalıklı sayıların en büyüğüdür.
             * -Parasal işlemlerde kullanılır.
             * -Ram da 16 byte lık yer kaplar.
             * 
             * 3-Mantıksal Veri Tipi:
             * 
             * -bool:
             * -Ram da 1 bit'lik yer kaplar.
             * -İçerisinde sadece 1 ve 0 barındırır.
             * 
             * 4-Metinsel Veri Tipleri:
             * 
             * 4.1-char:
             * -İçerisinde sadece 1 karakter barındırır.
             * - Örnek: 'A' , '8' , '?'
             * 
             * 4.2-string:
             * -Bizim en çok kullanacağımız tiptir.
             * -İçerisnde metinsel ifade barındırır.
             * -Örnek: "Deneme"
             * 
             * 5-Objecet(Nesne):
             * -Özel bir tiptir.
             * -Bütün tipleri içerisinde barındırabilir.
             * 
             */

            // Değişken Tanımlama
            byte sayi = 15;
            string metin = "Hello World";
            char karakter = 'A';
            bool mantiksal = true;
            double ondalikli = 14.5;
            object nesne = 4;
            nesne = "Ahmet";
            nesne = 21.7;
            nesne = false;


            mantiksal = (bool)nesne;
            Console.WriteLine(mantiksal);
            Console.ReadLine();
        }
    }
}
