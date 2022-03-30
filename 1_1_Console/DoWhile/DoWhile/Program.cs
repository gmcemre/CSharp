using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 2-Do While Döngüsü:
             * 
             * Yazımı:
             * 
             * do
             * {
             * 
             * }while(koşul);
             *
             */

            // Kullanıcı istediği kadar sayı girsin 0 girdiği anda o ana kadar girdiği sayıların toplamını ekrana yazdıran uygulama.

            int sayi, toplam = 0;
            int sayac = 1;

            do
            {
                Console.Write(sayac + ".Sayıyı Giriniz : ");
                sayi = Convert.ToInt32(Console.ReadLine());
                toplam += sayi;
                sayac++;
            } while (sayi != 0);

            Console.WriteLine("Girmiş olduğunuz sayıların toplamı : {0}", toplam);

            Console.ReadLine();
        }
    }
}
