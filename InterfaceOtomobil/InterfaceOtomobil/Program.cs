using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOtomobil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Focus focus = new Focus();
            Console.WriteLine(focus.HangiMarka().ToString());  //hangi marka metodu geriye enum dönüyor. enumın string değerini almak için dönüştürdük.
            Console.WriteLine(focus.KacTekerlek().ToString());
            Console.WriteLine(focus.StandartRengi().ToString());

            Civic civic = new Civic();
            Console.WriteLine(civic.HangiMarka().ToString());
            Console.WriteLine(civic.KacTekerlek().ToString());
            Console.WriteLine(civic.StandartRengi().ToString());

            Corolla corolla = new Corolla();
            Console.WriteLine(corolla.HangiMarka().ToString());
            Console.WriteLine(corolla.KacTekerlek().ToString());
            Console.WriteLine(corolla.StandartRengi().ToString());

            Console.ReadKey();

            //Bu şekilde aslında ortak olan özellikleri interface üzerinde toplayıp classları da ondan kalıtım aldırarak çerçevesini belirlemiş olduk
        }
    }
}
