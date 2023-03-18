using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOtomobil
{
    public class Focus : IOtomobil
    {
        public Marka HangiMarka()
        {
            return Marka.Ford;
        }

        public int KacTekerlek()
        {
            return 4;
        }

        public Renk StandartRengi()
        {
            return Renk.Beyaz;
        }
    }
}
