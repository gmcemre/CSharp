using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KararYapilari
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Karar Yapıları
             * 
             *  if - Else:
             *  
             *  if(koşul)
             *  {
             *  
             *  }
             *  else if(koşul)
             *  {
             *  
             *  }
             *  else if(koşul)
             *  {
             *  
             *  }
             *  else
             *  {
             *  
             *  }
             * 
             */

            string kullaniciAdi = "Admin";
            string parola = "123";
        BASADON:
            Console.Write("Kullnaıcı Adı : ");
            string kAdi = Console.ReadLine();
        _BASADON:
            Console.Write("Parola : ");
            string prl = Console.ReadLine();

            if (kullaniciAdi == kAdi && parola == prl)
            {
                Console.WriteLine("Hoşgeldin {0}", kAdi);
            }
            else if (kullaniciAdi != kAdi)
            {
                Console.WriteLine("Hatalı Kullanıcı Adı.Tekrar Deneyiniz!!");
                goto BASADON;
            }
            else if (parola != prl)
            {
                Console.WriteLine("Hatalı Şifre.Tekrar Deneyiniz!!");
                goto _BASADON;
            }
            Console.Clear();

            //Girilen iki sayıdan hangisinin büyük hangisinin küçük olduğunu söyleyen uygulamayı yazınız.
            Console.Write("1.Sayı : ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2.Sayı : ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            if (sayi1 > sayi2)
            {
                Console.WriteLine("{0} > {1}", sayi1, sayi2);
            }
            else if (sayi1 == sayi2)
            {
                Console.WriteLine("{0} = {1}", sayi1, sayi2);
            }
            else
            {
                Console.WriteLine("{0} < {1}", sayi1, sayi2);
            }


            Console.ReadLine();
        }
    }
}
