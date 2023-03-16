using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //  //Sınıf içerisindeki fieldları dışarı kontrollü bir şekilde açmamızı sağlayan yapılardır.

        //    Ornek o = new Ornek();

        //    o.Adi = "hjksdhjk"; // bu şekilde buna bir veri girdiğim zaman çalışacak yer set bloğu. Girdiğim yeri value anahtar sözcüğüyle yakalayacak. Arka planda ilgili field'ımıza bu değeri atayacak.
        //    Console.WriteLine(o.Adi); //ama eğer nesnemiz üzerinden propertydeki veriyi çağırıyorsam get bloğu çalışır. Fieldımızdaki veriyi bize döndürür.

        //    o.sayi = 123;
        //    Console.WriteLine(o.sayi);

        //    Console.WriteLine(o.yazı);

        //    Console.ReadKey();
        //}

        //class Ornek
        //{
        //    string adi;

        //    public string Adi // isimlendirme genelde field'ın büyük harfle başlamış hali olur. Scope'la başlarsa property'dir.
        //    {
        //        get {
        //            return adi; //bu property çağrıldığı zaman hangi veri gönderilecektir? return komutu ile adı fieldını dışarı açmış oluyoruz. Bu property çağrıldığında geriye bu değeri döndermek istiyorsam fieldımı get metoduyla dışarı açıyorum.
        //        }
              
        //        set {
        //            adi = value; //dışarıdan bu propertiye gönderilen bir değer nereye gönderilecektir, üzerinde ne işlem yapılacaktır, düzenlecektir? Value anahtar kelimesiyle dışarıdan gönderilen değer yakalanır, genellikle value'ya da elimizdeki mevcut field'ı atarız, set işlemini gerçekleştiririz.
        //        }             
        //    }

        //    public int sayi { get; set; } //eğer field'ımızda bir kontrol gerçekleştirmeyeceksek. bu property arka planda kendi field'ını oluşturuyor ve kontrolsüz bir şekilde işlem yapmamızı sağlıyor.

        //    public string yazı { get; set; } = "furkan"; //ilk değeri atamak istiyorsak
        //}
    }

    
}
