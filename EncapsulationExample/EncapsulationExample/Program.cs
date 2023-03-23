using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personel pers = new Personel();
            pers.TCKIMLIKNO = "12345678914";

            Console.WriteLine("TC Kimlik No: " + pers.TCKIMLIKNO);

            Console.ReadKey();
        }
    }
}
