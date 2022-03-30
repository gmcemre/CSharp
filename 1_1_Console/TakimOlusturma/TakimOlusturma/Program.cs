using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakimOlusturma
{
    class Program
    {
        static void Main(string[] args)
        {
            //Takım Oyunu

            //1.Adım: Kullanıcıya kaç isim gireleceği sorulup girilen adet boyutunda dizi tanımlanacak.
            //Girilen adet çift sayı olmak zorundadır.

            int adet = 0;
            string[] isimler = new string[0];
            do
            {
                Console.Write("Kaç İsim Girilecek : ");
                adet = Convert.ToInt32(Console.ReadLine());

                if (adet % 2 == 0)
                {
                    isimler = new string[adet];
                }
                else
                {
                    Console.WriteLine("Lütfen çift sayı giriniz!");
                }

            } while (adet % 2 != 0);

            //2.Adım: Kullanıcının belirtmiş olduğu adet kadar oyuncu ismi girmesini sağlamak ve bu isimleri diziye atmak.Ancak bir isim dizide bir kez bulunabilmelidir.

            for (int i = 0; i < isimler.Length; i++)
            {
                Console.Write("{0}.İsmi Giriniz : ", i + 1);
                string isim = Console.ReadLine();
                if (isimler.Contains(isim))
                {
                    Console.WriteLine("Girmiş olduğunuz isim takımda zaten var!Tekrar giriniz.");
                    i--;
                }
                else
                {
                    isimler[i] = isim;
                }
            }

            //3.Adım: İki tane takım oluşturulmalı ve oyuncular eşit sayılarda rastgele bir şekilde takımlara dağıtılmalıdır.
            //Kural 1 : Bir oyuncu sadece bir takımda bulunabilir.
            //Kural 2 : Bir oyuncu bir takımda bir kez bulunabilir.

            string[] aTakimi = new string[isimler.Length / 2];
            string[] bTakimi = new string[isimler.Length / 2];

            Random rnd = new Random();

            for (int i = 0; i < isimler.Length / 2; i++)
            {
                string isim = isimler[rnd.Next(isimler.Length)];
                if (aTakimi.Contains(isim))
                {
                    i--;
                }
                else
                {
                    aTakimi[i] = isim;
                }
            }

            for (int i = 0; i < isimler.Length / 2; i++)
            {
                string isim = isimler[rnd.Next(isimler.Length)];
                if (!bTakimi.Contains(isim) && !aTakimi.Contains(isim))
                {
                    bTakimi[i] = isim;
                }
                else
                {
                    i--;
                }
            }
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("A Takımı:");
            foreach (string item in aTakimi)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n-------------------------------------------------");
            Console.WriteLine("B Takımı:");
            foreach (string item in bTakimi)
            {
                Console.Write(item + " ");
            }

            Console.ReadLine();
        }
    }
}
