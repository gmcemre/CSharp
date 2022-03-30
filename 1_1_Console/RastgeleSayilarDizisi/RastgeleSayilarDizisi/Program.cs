using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RastgeleSayilarDizisi
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1-) 10 elemanlı bir diziyi , her sayıdan bir tane bulunmak koşulu ile rastgele sayılarla dolduran ve bu sayıları ekrana yazan uygulamayı yazınız.
             */

            //1.Adım : 10 elemanlı bir dizi oluşturulur.
            int[] sayilar = new int[10];

            //2.Adım : Rastgele sayılarla doldurmak için rastgele sayı üreten bir değişken tanımlamak.
            Random rnd = new Random();

            //3.Adım : Diziyi her sayıdan bir tane bulunmak koşulu ile rastgele sayılarla doldurmak.
            int sayac = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                int sayi = rnd.Next(11);
                if (sayilar.Contains(sayi))
                {
                    sayac++;
                    i--;
                }
                else
                {
                    sayilar[i] = sayi;
                }
            }
            Console.WriteLine("Dizinin Elemanları;");
            foreach (int item in sayilar)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n" + sayac);


            Console.ReadLine();
        }
    }
}
