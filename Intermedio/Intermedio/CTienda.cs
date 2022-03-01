using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermedio
{
    class CTienda
    {
        public static void MandaViveres(int kilos)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-->Vamos a mandar sus viveres, estoy en la tienda.");
            Console.WriteLine("-->Serán {0} kilos", kilos);
        }
    }
}
