using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermedio
{
    class CAuto : IAutomovil
    {
        double costo;
        double tenencia;
        string modelo;

        public CAuto(string modelo, double costo)
        {
            this.modelo = modelo;
            this.costo = costo;
        }

        public void CalculaTenencia(double imp)
        {
            tenencia = 5000.0 + costo * imp;
        }

        public void MuestraInformacion()
        {
            Console.WriteLine("Tu automóvil {0}", modelo);
            Console.WriteLine("Costo {0}, con una tenencia de {1}", costo, tenencia);
            Console.WriteLine("Total {0}", costo + tenencia);
            Console.WriteLine("---------------------------");
        }
    }
}
