using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiTahminOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            // ******* Sayı Tahmin Oyunu *******
            /*Bilgisayar arka planda hafızasında rastgele bir sayı tutacak.
             *Kullanıcı tuttulan rastgele sayıyı tahmin etmeye çalışacak.
             *Sadece 5 hakkı olacak.
             *Tahmin edilen değer tutulan değerden büyükse daha küçük bir sayı giriniz , küçükse daha büyük bir sayı giriniz bilgilendirmesi yapılacak.
             *Bilirse Tebrikler bildiniz yazacak.
             *Bilemezse tahmin etmeye devam edecek.Hakkı bittiğinde oyun bitecek.
             */

            Console.WriteLine("***** Sayı Tahmin Oyunu *****");
            Console.WriteLine("-------------------------------------");

            Random rnd = new Random();
            int tutulanDeger = rnd.Next(1, 21);
            int hak = 0;
            int tahmin;
            Console.WriteLine("*** 1 ile 20 arasında (1 ve 20 dahil) bilgisayar tarafından tutulan sayıyı tahmin ediniz. ***");
            do
            {
                Console.WriteLine("---------------------------------------------------------------------------------------------");
                Console.Write((hak + 1) + ".Tahmin : ");
                tahmin = Convert.ToInt32(Console.ReadLine());
                hak++;
                if (0 < tahmin && tahmin < 21)
                {
                    if (tahmin < tutulanDeger && hak != 5)
                    {
                        Console.WriteLine("İPUCU : Daha büyük bir değer giriniz!!!");
                    }
                    else if (tahmin > tutulanDeger && hak != 5)
                    {
                        Console.WriteLine("İPUCU : Daha küçük bir değer giriniz!!!");
                    }
                }
                else
                {
                    Console.WriteLine("Lütfen belirtilen aralıkta bir değer giriniz!!!");
                }

            } while (tahmin != tutulanDeger && hak != 5);

            if (tahmin == tutulanDeger)
            {
                Console.WriteLine("Tebrikler Bildiniz :))");
            }
            else
            {
                Console.WriteLine("Bilgisayar tarafınfan tutulan sayı : " + tutulanDeger);
                Console.WriteLine("Hakkınız Bitti.Kaybettiniz :((");
            }

            Console.ReadLine();
        }
    }
}
