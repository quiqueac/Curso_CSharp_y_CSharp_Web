using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermedio
{
    class CRadio
    {
        public static void MetodoRadio(string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Estamos en la clase radio.");
            Console.WriteLine("Este es tu mensaje {0}", mensaje);
        }
    }
}
