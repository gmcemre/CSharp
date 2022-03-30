using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıda girilen iki sayı '* arasındaki *' tek ve çift sayıların toplamını yazdıran uygulama.
            Console.Write("1.Sayıyı Giriniz : ");
            int kullaniciGelenDeger1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2.Sayıyı Giriniz : ");
            int kullaniciGelenDeger2 = Convert.ToInt32(Console.ReadLine());
            int tekToplam = 0;
            int ciftToplam = 0;
            if (kullaniciGelenDeger1 < kullaniciGelenDeger2)
            {
                while (kullaniciGelenDeger1 < kullaniciGelenDeger2 - 1)
                {
                    if ((kullaniciGelenDeger1 + 1) % 2 == 0)
                    {
                        ciftToplam += kullaniciGelenDeger1 + 1;
                    }
                    else
                    {
                        tekToplam += kullaniciGelenDeger1 + 1;
                    }

                    kullaniciGelenDeger1++;
                }

                Console.WriteLine("Girilen iki sayı arasındaki Çift sayıların toplamı : " + ciftToplam);
                Console.WriteLine("Girilen iki sayı arasındaki Tek sayıların toplamı : " + tekToplam);
            }
            else if (kullaniciGelenDeger1 > kullaniciGelenDeger2)
            {
                while (kullaniciGelenDeger1 > kullaniciGelenDeger2 + 1)
                {
                    if ((kullaniciGelenDeger1 - 1) % 2 == 0)
                    {
                        ciftToplam += kullaniciGelenDeger1 - 1;
                    }
                    else
                    {
                        tekToplam += kullaniciGelenDeger1 - 1;
                    }

                    kullaniciGelenDeger1--;
                }
                Console.WriteLine("Girilen iki sayı arasındaki Çift sayıların toplamı : " + ciftToplam);
                Console.WriteLine("Girilen iki sayı arasındaki Tek sayıların toplamı : " + tekToplam);
            }
            else
            {
                Console.WriteLine("Girmiş olduğunuz sayılar eşit tekrar giriniz.");
            }


            Console.ReadLine();

        }
    }
}
