using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Uygulama geliştirirken sabit değerlerle çalışmak durumunda kalırız. Bu noktalarda okunabilirliği yüksek bir program yazmak istiyorsak enum'lardan faydalanırız.

            // "enum" anahtar kelimesi enumeration yani numaralandırma kelimesinden gelir.Sayısal verilerı string ifadelerle saklamanızı sağlar. Okunabilirliğe katkısı da tam olarak burdan gelir diyebiliriz.

            Console.WriteLine((int)Gunler.Pazartesi);




            int sıcaklık = 32;

            if(sıcaklık <= (int)HavaDurumu.normal)
            {
                Console.WriteLine("dışarıya çıkmak için soğuk");
            }
            else if (sıcaklık >= (int)HavaDurumu.çokSıcak)
            {
                Console.WriteLine("dışarıya çıkmak için sıcak bir gün");
            }
            else { Console.WriteLine("haydi dışarıya"); }
            Console.ReadKey();
        }
    }
    enum Gunler
    {
        Pazartesi,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma = 23,
        Cumartesi,
        Pazar
    }


    enum HavaDurumu
    {
        soguk = 5,

        normal = 20,

        sıcak = 30,

        çokSıcak = 35,
    }
}
