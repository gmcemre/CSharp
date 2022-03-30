using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipDonusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Tip Dönüşümleri : Bir tipteki değeri başka bir tipe dönüştürmeyi sağlar.
             * 
             * 1-Cast:
             * 1-1: Implictly Cast:
             * -Kendi kendine dönüşüm işlemi yapar.
             * -Bizim ayrıca dönüşüm işlemi yapmamıza gerek yoktur.
             * -Not:Kesinlikle bir tip diğer tipin içerisinde barınabiliyorsa gerçekleşir.
             * 
             * 1-2: Explictly Cast:
             * -Benzer tipler arasında dönüşüm yapmayı sağlar.
             * -Bu kez dönüşüm işlemini biz yaparız.
             * 
             * 2-Convert ve Parse:
             * -Cast işleminin yetersiz olduğu durumlarda kullanılır.-Metinsel bir ifadeyi cast yöntemi ile bir tipe dönüştüremyiz.
             * 
             * 2.1-Parse:
             * -Sadece string bir değeri başka bir tipe dönüştürmeyi sağlar.
             * -Her tipin içerisinde Parse metodu bulunur.
             * -Convert'e göre daha performanslıdır fakat daha yeteneksizdir.
             * 
             * 2.2-Convert:
             * -Herhangi bir tipi  herhangi bir tipe dönüştürebilir.
             * -Parse'a göre daha yetenekli fakat daha performanssızdır.
             * 
             */
            //Kullanıcıdan alınan iki sayının toplamını yazdıran uygulama.

            Console.Write("1.Sayıyı Giriniz : ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2.Sayıyı Giriniz : ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            int toplam = sayi1 + sayi2;
            Console.Write("Sayıların Toplamı : {0} + {1} = {2} ", sayi1, sayi2, toplam);

            Console.ReadLine();
        }
    }
}
