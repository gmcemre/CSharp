using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Diziler:
             * -Aynı iş ve aynı amaç için içerisinde birden fazla değer barındırmayı sağlayan yapılardır.
             * -Dizileri tanımlarken; ne kadar yer kaplayacakları yani içerisinde kaç tane elaman barındıracakları belli olsun diye tanımlama sırasında adet verilir.
             * -Her tipin dizisi olabilir.
             * -Herhangi bir tipi dizi haline getirmek için tipin sonuna "[]" konulur.
             * -Faydası : Aynı isim altında bir tipe ait birden fazla değer tutabilir.
             * 
             * -Dizilerde numaralandırma index diye adlandırılır.
             * -Ve 0'dan başlar.Yani 1. sıradaki elemanın index numarası 0 dır.
             * 
             * Tanımlama şekli:
             * 
             * string[] isimler = new string[10];
             */

            string[] isimler = new string[10];
            int[] sayılar = new int[5];

            //Diziye değer atama yöntemi:
            isimler[4] = "Emre";
            sayılar[0] = 4;

            //Object Initilazier
            char[] karakterler = { 'A', '7', '?', 'B', 'C' };

            //Dizilerin boyutu nasıl arttırılır.
            Array.Resize(ref karakterler, 6);
            karakterler[5] = 'W';
            Console.WriteLine(karakterler[5]);

            //Dizilerin boyutunu öğrenme:
            int boyut = isimler.Length;
            Console.WriteLine(boyut);

            //Herhangi bir dizinin boyutunu var olan boyutundan 1 arttırmak istersek ne yapmalıyız.

            Array.Resize(ref isimler, (isimler.Length + 1));
            int boyut2 = isimler.Length;
            Console.WriteLine(boyut2);

            Console.ReadLine();
        }
    }
}
