using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwicthCase
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Karar Yapıları
             * 
             * 2-Swicth Case
             * 
             * Yazılışı:
             * 
             * swicth(koşul)
             * {
             *      case 1 : şunu yap; 
             *          break;
             *      case 2 : bunu yap;
             *          break;
             * }
             * 
             * Not: If-Else yapısından daha yeteneksizdir.Ama daha performanslıdır.
             */

            //Kullanıcının girdiği mevsimde bulunan ayları listeleyen uygulamayı yazınız.
            
            Console.Write("Mevsim giriniz : ");
            string mevsim = Console.ReadLine();

            switch (mevsim)
            {
                case "Yaz":
                    Console.WriteLine("Haziran-Temmuz-Ağustos");
                    break;
                case "Kış":
                    Console.WriteLine("Aralık-Ocak-Şubat");
                    break;
                case "Sonbahar":
                    Console.WriteLine("Eylül-Ekim-Kasım");
                    break;
                case "İlkbahar":
                    Console.WriteLine("Mart-Nisan-Mayıs");
                    break;
                default:
                    Console.WriteLine("Girilen değer yanlıştır.Lütfen mevsim giriniz.");
                    break;
            }
           

            Console.ReadLine();
        }
    }
}
