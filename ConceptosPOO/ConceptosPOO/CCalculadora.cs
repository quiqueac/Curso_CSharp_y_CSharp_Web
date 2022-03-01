using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosPOO
{
    // Esta clase es definida por nosotros
    class CCalculadora
    {
        // Declaramos los atributos
        public double a;
        public double b;
        private double r;

        // Declaramos los métodos
        public void Suma()
        {
            // Se lleva a cabo una acción
            r = a + b;

            // Invocamos al método privado
            Muestra();
        }

        private void Muestra()
        {
            Console.WriteLine("a = {0}, b = {1}, r = {2}", a, b, r);
        }
    }
}
