using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOtomobil
{
    public class Civic : IOtomobil
    {
        public Marka HangiMarka()
        {
            return Marka.Honda;
        }

        public int KacTekerlek()
        {
            return 4;
        }

        public Renk StandartRengi()
        {
            return Renk.Gri;
        }
    }
}
