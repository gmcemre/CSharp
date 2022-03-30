using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IkiSayiArasindakiAsalSayilar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcının girmiş olduğu iki sayı arasındaki asal sayışarı bulup ekrana yazan uygulama.

            int sayi1, sayi2;
            do
            {
                bool sonuc = true;
                Console.Write("1.Sayı : ");
                sayi1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("2.Sayı : ");
                sayi2 = Convert.ToInt32(Console.ReadLine());
                if (sayi1 < sayi2)
                {
                    for (int i = sayi1; i <= sayi2; i++)
                    {
                        if (sayi1 == 2)
                        {
                            Console.WriteLine(i);
                        }
                        else if (sayi1 > 2)
                        {
                            for (int j = 2; j < sayi1; j++)
                            {
                                if (i % j == 0)
                                {
                                    //Asal Değil
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
                }
                else if (sayi1 > sayi2)
                {
                    for (int i = sayi2; i <= sayi1; i++)
                    {
                        if (sayi2 == 2)
                        {
                            Console.WriteLine(i);
                        }
                        else if (sayi2 > 2)
                        {
                            for (int j = 2; j < sayi2; j++)
                            {
                                if (i % j == 0)
                                {
                                    //Asal Değil
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
                }
                else
                {
                    Console.WriteLine("Girmiş olduğunuz sayılar birbirine eşit.Tekrar Deneyiniz!!");
                }
            } while (sayi1 == sayi2);

            Console.ReadLine();
        }
    }
}
