using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Döngüler
             * Belirli kod bloğunu belirli bir koşula göre tekrar tekrar çalıştırmayı sağlayan yapılardır.
             * 
             * 4 tane döngü çeşidi vardır.
             * 
             * 1-While Döngüsü:
             * 
             * Yazımı:
             * 
             * while (koşul)
             * {
             *      
             * }
             */

            //int sayac = 1;
            //while (sayac <= 100)
            //{
            //    Console.WriteLine(sayac+ "- Merhaba Dünya");
            //    sayac++;
            //}

            //1 ile 100 arasındaki tek ve çift sayıların toplamını ekrana yazdıran uygulama.

            int sayi = 0;
            int toplamCift = 0;
            int toplamTek = 0;
            while (sayi < 100)
            {
                if (sayi % 2 == 0)
                {
                    toplamCift += sayi;
                }
                else
                {
                    toplamTek += sayi;
                }

                sayi++;
            }

            Console.WriteLine("1 den 100 e kadar olan çift sayıların toplamı: " + toplamCift);
            Console.WriteLine("1 den 100 e kadar olan tek sayıların toplamı: " + toplamTek);

            Console.ReadLine();
        }
    }
}
