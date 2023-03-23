using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationExample
{
    public class Personel
    {
        private string tckimlikno;

        public string TCKIMLIKNO
        {
            get
            {
                return tckimlikno.Substring(0,5)+"******";
            }

            set 
            {
                bool kontrol = false;

                if(value.Length==11) //kullanıcının girdiği değeri value anahtar kelimesiyle yakaladım. value içerisinde bazı metotlar ve propertyler tanımlanmıştır.
                {
                    for(int i = 0; i<value.Length; i++)
                    {
                        bool sayiMi = char.IsNumber(value[i]); //char'ın içerisinde bazı hazır metotlar var. senden char veri tipinde, yani bir karakter istiyorum, sana boolean döndürürüm.

                        if (sayiMi)
                        {
                            //Yapmam gereken bir iş yok
                        }
                        else
                        {
                            kontrol = true; //dipnot: kontrol değişkenimiz olmasa algoritmayı yapamayız. true'ya çekip aşağıda kullanıyoruz.
                            break;
                        }
                    }
                    if(kontrol)
                    {
                        Console.WriteLine("LÜTFEN TC NO İÇİ SADECE SAYI GİRİNİZ.");
                    }
                    else
                    {
                        tckimlikno = value; // eğer herşey doğruysa değişkenime value anahtar kelimesini atıyorum.
                    }

                }
                else
                {
                    Console.WriteLine("TC NO 11 KARAKTER OLMAK ZORUNDADIR");
                }
            }
            
        }
    }
}
