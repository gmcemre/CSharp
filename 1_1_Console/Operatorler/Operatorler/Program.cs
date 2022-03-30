using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1-Matematiksel Operatörler:
             * 
             *  + , - , * , /
             *  ++
             *  --
             *  %
             *  -=
             *  +=
             *  *=
             *  /=
             *  Not: ++ veya -- operatörü değişkenin önünde (solunda) ise değişkeni önce işleme sokar daha sonra kullanırız.
             *  Not: ++ veya -- operatörü değişkenin arkasında (sağında) ise önce değişkeni kullanırız sonra işleme sokar
             *  
             */


            int a = 5;
            a = a + 10;
            a += 10;
            a -= 10;
            a *= 10;
            a /= 10;

            int b = 0;

            b = ++a; // b=6 (önce artttırır sonra atama yapar.)
            b = a++; // b=5 bundan sonraki satırlarda a=6 olarak devam eder.(önce atama yapar sonra arttırır.)

            a = 5;
            a = a++ + --a;

            /*
             * 2-İlişkisel Operatörler:
             * 
             * == : Eşit mi?
             * <  : Küçük mü?
             * >  : Büyük mü?
             * <= : Küçük eşit mi?
             * >= : Büyük eşit mi?
             * != : Eşit değil mi?
             * 
             * !< : Küçük değil mi? (kullanılmıyor çok falza)
             * !> : Büyük değil mi? (kullanılmıyor çok falza)
             */


            /*
             * 3-Mantıksal Operatörler:
             * & => ve 
             * | => veya 
             * ! => değil
             */





        }
    }
}
