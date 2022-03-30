using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsalSayilar
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // 1' den 100'e kadar olan sayıların bölenlerini veren uygulama.
            //for (int i = 1; i < 100; i++)
            //{
            //    Console.Write("{0} sayısının bölenleri : ", i);
            //    for (int j = 1; j < 100; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            Console.Write(j + " ");
            //        }
            //    }
            //    Console.WriteLine();
            //}



            // 2-100 arasındaki asal sayıları bulup bunları ekrana yazan uygulama.

            bool sonuc = true;
            for (int i = 2; i <= 100; i++)
            {
                if (i == 2)
                {
                    //Asal Sayıdır
                    Console.WriteLine(i);
                }
                else if (i > 2)
                {
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            //Asal değil
                            sonuc = false;
                            break;
                        }
                        else
                        {
                            //Asal
                            sonuc = true;
                        }
                    }
                    if (sonuc)
                    {
                        Console.WriteLine(i);
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
