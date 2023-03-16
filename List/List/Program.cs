using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //arraylist koleksiyonu içerisine birden fazla tipte değer alırken List koleyksiyonu(Generic-) özelleştirilmiş koleksiyon olduğundan dolayı içerisine sadece belirlediğimia tipte veriler alacaktır.
            //arraylist birden fazla tipte veri aldığı için, çalışırken tip kontrolü yapma mecburiyetinde kalabiliyorduk. nihayetinde o anda elimize gelen tip hangisiyse ona göre şu işlemi yap diyorduk. Bunları ortadan kaldıran şey List koleksiyonudur.

            //List<int> liste = new List<int>(); //parantez içinte nesne de olabilirdi.
            //liste.Add(1); //koleksiyonumuzun tipi string olsaydı, string tipte veri alacaktı.

            //int[] Sayilar = new int[30];
            //dizilerde eleman sayısını önceden belirtmemiz gerekiyor
            //elemanların hepsini atamasak bile atanmayanlar için  bellekte onlar için yer kaplıyor.
            //Performans açısından zayıf
            //eleman atarken, okurken fazla kod

            ArrayList liste1 = new ArrayList();
            liste1.Add("Furkan");   //değer atarken indexer kullanıyoruz
            liste1.Add("Kılıç");
            liste1.Add(3);
            liste1.Add(true);
            liste1.Add('a');

            //liste1[1]; //değer çağırırken indexer kullanıyoruz

            //içine atanacak veriler object olarak tanımlamıştır. bu arka planda boxing işlemine tabi tutuluyor demektir.
            //Biz arraylistin içerisindeki herhangi bir elemanı elde edip o elemanı kendi tipinde çalışmak istiyorsak burada da unboxing işlemine tabi tutup o tipte elemanı elde ederek çalışmak zorundayız. bundan dolayı artık arraylist tercih edilmiyor

            foreach (var item in liste1)
            {
                if (item is int)
                {
                    Console.WriteLine((int)item + 120); //unboxing yaptık
                }
            }

            Console.ReadKey();


        }
    }
}
