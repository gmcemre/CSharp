using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForDongusu
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * For Döngüsü
             */

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
            Console.Clear();

            //Kullanıcının girmiş olduğu sayının faktöriyelini hesaplayan uygulama.

            //1.ADIM : Kullanıcın sayı girmesini sağlamak ve girilen sayıyı bir değişkende tutmak.
            Console.Write("Faktöriyelini almak istediğiniz sayıyı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            //2.ADIM : Sayının Faktöriyelinin Hesaplanması 
            int faktöriyel = 1;
            if (sayi == 0)
            {
                Console.WriteLine("0 sayısının faktöriyeli 1'dir.");
            }
            else
            {
                for (int i = 1; i <= sayi; i++)
                {
                    faktöriyel *= i;
                    if (i < sayi)
                    {
                        Console.Write($"{i}*");
                    }
                    else
                    {
                        Console.WriteLine($"{i}={faktöriyel}");
                    }
                }

                Console.WriteLine($"{sayi}! = {faktöriyel}");

                //Ya Da Geriye Doğru 
                //for (int i = sayi; i > 0; i--)
                //{
                //    faktöriyel *= i;
                //}
                //Console.WriteLine($"{sayi}! = {faktöriyel}");
            }

            /*
             * break;
             * break komutu ile istediğimiz bir koşulda döngüden çıkabiliriz.(Tüm i değerlerini dönmeden)
             */


            Console.ReadLine();
        }
    }
}
