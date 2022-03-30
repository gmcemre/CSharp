using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdanZyeEkranaYazma
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 3-) Console ekranına a'dan z'ye kadar harfleri yazan uygulamayı yazınız.
             */

            //a'dan z'ye kadar ki harfleri direkt yaz.
            for (char i = 'a'; i <= 'z'; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            //a'dan z'ye kadar olan harflerin ascii kodlarını yaz.
            for (int i = 'a'; i <= 'z'; i++)
            {
                Console.Write("{0} ", i);
            }

            Console.WriteLine();

            //ascii kodları dönen döngüde harf değişkenine dönen sayıları char tipine dönüştürüp atayarak ekrana yaz.
            for (int i = 97; i <= 122; i++)
            {
                char harf = Convert.ToChar(i);
                Console.Write(harf + " ");
            }
            Console.ReadLine();
        }
    }
}
