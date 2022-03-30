using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpimTablosu
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 2-) Console ekranına çarpım tablosunu yazdıran uygulamayı yazınız.
             * Örneğin;
             *   1x1=1
             *   1x2=2 vs.
             *   
             */

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    int sonuc = i * j;
                    Console.WriteLine("{0}x{1}={2}", i, j, sonuc);
                }
                Console.WriteLine("--------------------");
            }

            Console.ReadLine();
        }
    }
}
