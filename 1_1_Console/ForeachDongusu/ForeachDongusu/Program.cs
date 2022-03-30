using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachDongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Foreach Döngüsü:
             * -Üç önemli kuralı vardır
             * 1-Sadece ileri gider.
             * 2-Readonly'dir.(SAdece okunabilir.Yani koleksiyon içerisindeki elemana değer ataması yapılamaz.)
             * 2-Koleksiyon yapısı foreach in çalışması sırasında değiştirelemez.
             * -Yazılışı:
             * foreach(elemanTipi degiskenIsmi in koleksiyon)
             * {
             * 
             * }
             * 
             * -Döngüler arasında en çok kullanacağımız döngü yapısıdır.***
             */

            char[] karakterler = { 'A', '5', 'f' };
            //char tipine 'int' yazarsak Ascii kodlarını getirir!!..
            foreach (int item in karakterler)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            foreach (char item in karakterler)
            {
                Console.Write($"{item} ");
            }


            Console.ReadLine();
        }
    }
}
