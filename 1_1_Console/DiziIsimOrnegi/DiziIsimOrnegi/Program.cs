using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziIsimOrnegi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan bir sayı girmesini talep edelim.
            //Girilen sayı kadar boyutu olan bir dizi tanımlayalım.
            //Kullanıcı talep ettiği boyut sayısı kadar isim girmesini isteyelim.
            //Girilen isimleri diziye ekleyelim
            //İsimler arasından hangi ismi aramak istiyorsunuz diye soralım.
            //Aramak istediğiniz isimden kaç adet mevcut sayalım.
            //Bu mevcut sayının kaç adet olduğu bilgisini kullanıcıya verelim.

            Console.Write("Oluşturmak istediğiniz dizinin boyutunu giriniz : ");
            int girilenBoyut = Convert.ToInt32(Console.ReadLine());
            string[] isimler = new string[girilenBoyut];
            Console.WriteLine("Lütfen belirttiğiniz adet kadar isim giriniz.");

            for (int i = 0; i < isimler.Length; i++)
            {
                Console.Write((i + 1) + ".İsim : ");
                string isim = Console.ReadLine();
                isimler[i] = isim;
            }

            Console.Write("Dizide aramak istediğiniz ismi giriniz : ");
            string arananIsim = Console.ReadLine();
            int sayac = 0;
            foreach (string isim in isimler)
            {
                if (arananIsim == isim)
                {
                    sayac++;
                }
            }

            Console.WriteLine("Aradığınız isim dizide {0} tane mevcut.", sayac);

            Console.ReadLine();
        }
    }
}
