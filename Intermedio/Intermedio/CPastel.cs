using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermedio
{
    class CPastel
    {
        public static void MostrarPastel(string anuncio)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("El pastel llevará el mensaje de {0}.", anuncio);
        }
    }
}
