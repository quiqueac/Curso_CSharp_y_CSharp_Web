using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermedio
{
    class CMultiplicacion : IOperacion
    {
        private double r;

        public void Calcular(double a, double b)
        {
            r = a * b;
        }

        public void Mostrar()
        {
            Console.WriteLine("El resultado de la multiplicación es {0}", r);
        }
    }
}
