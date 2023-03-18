using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOtomobil
{
    public class Corolla : IOtomobil
    {
        public Marka HangiMarka()
        {
            return Marka.Toyota;
        }

        public int KacTekerlek() //refactor edilebilir bir yer
        {
            return 4;
        }

        public Renk StandartRengi()
        {
            return Renk.Beyaz;
        }
    }
}
