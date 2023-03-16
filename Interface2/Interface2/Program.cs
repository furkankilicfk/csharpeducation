using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface2
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    //Nesne oluşturulamaz. Referans noktası oluşturulabilir. Bir sınıf bir veya birden fazla interface'ten kalıtım alabilir.  Interface içerisinde imzası tanımlanmış yapıların gövdeleri interfaceten kalıtım alan classlarda yazılır.
        //}

        //interface IOrnek
        //{
        //    //İmzalarda public private, protected vs. gibi erişim belirleyicileri olmaz. İmza-Gövde işi abstract ile aynıdır.

        //    int X();

        //    void Y();

        //    int OrnekProperty { get; set; } //metotta da erişim belirleyici uygulanamaz. İsimlerin sınıflandırması olmalı.
        //}

        //class Ornek : IOrnek
        //{
        //    public int OrnekProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        //    //x metodu burada uygulanacak
        //    public int X()
        //    {
        //        throw new NotImplementedException();
        //    }

        //    public void Y()
        //    {
        //        throw new NotImplementedException();
        //    }
        //}


        static void Main(string[] args)
        {
            Ornek ornek = new Ornek(); //olmuyor. Private olayı. REFERANS!!! Kalıtımı alanın nesnesini oluşturuyoruz. Kalıtımı verenin referansıyla.
            IA o = new Ornek();
            o.x();
            IB b = new Ornek();

            b.x();

            Console.ReadKey();

        }
        interface IA
        {
            void x();

            void y();

            void z();
        }

        interface IB
        {
            void x();

            void m();

            void n();
        }

        //Name hiding durumu olma ihtimali varsa implement interface explicitly seçeneğini kullanırız. İkisinde de x() metodu var. hangisini getirdiğine dair sorun yaşarız.

        //bir sınıf:  bir sınıftan ve interfaceten kalıtım alacaksa, : önce sınıflar, sonra interfazeler yazılır.
        class Ornek : IA, IB
        {
            void IB.m()
            {
                throw new NotImplementedException();
            }

            void IB.n()
            {
                throw new NotImplementedException();
            }

            void IA.x()
            {
                Console.WriteLine("Tugrçe");
            }

            void IB.x()
            {
                Console.WriteLine("ahmet");
            }

            void IA.y()
            {
                throw new NotImplementedException();
            }

            void IA.z()
            {
                throw new NotImplementedException();
            }
        }
    }
}
//Böyle de hepsi otomatik private gelir. Yukadıra nesne üzerinden ulaşamayız. Yanlarına public de yazamayız. Polymorphysm kullanmak zorunda kalırız.REFERANS NOKTASI--