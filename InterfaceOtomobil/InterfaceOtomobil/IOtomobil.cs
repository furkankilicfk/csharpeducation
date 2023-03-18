using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOtomobil
{
    public interface IOtomobil
    {
        int KacTekerlek();

        Marka HangiMarka(); //Baştakiler enum

        Renk StandartRengi();
    }
}
