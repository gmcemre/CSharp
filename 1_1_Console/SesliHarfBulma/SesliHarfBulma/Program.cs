using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SesliHarfBulma
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sesli Harf Bulma Uygulaması

            //1.ADIM : Kullanıcıdan kelime istenmeli ve bu kelime bir değğişkende tutulmalı.

            Console.Write("Kelime : ");
            string kelime = Console.ReadLine();

            char[] sesliHarf = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü', 'A', 'E', 'I', 'İ', 'O', 'Ö', 'U', 'Ü' };
            int sayac = 0;
            foreach (char item in kelime)
            {
                bool sonuc = sesliHarf.Contains(item);
                if (sonuc)
                {
                    Console.Write(item + " ");
                    sayac++;
                }

            }

            Console.WriteLine("\n{0} kelimesinde toplam {1} adet sesli harf mevcut.", kelime, sayac);
            Console.ReadLine();

        }
    }
}
