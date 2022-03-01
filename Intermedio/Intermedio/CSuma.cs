using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermedio
{
    class CSuma : IOperacion
    {
        double r = 0;
        private ArrayList resultados = new ArrayList();

        public void Calcular(double a, double b)
        {
            r = a + b;
        }

        public void Mostrar()
        {
            Console.WriteLine("El resultado de la suma es {0}", r);
            resultados.Add(r);
        }

        public void MostrarResultados()
        {
            foreach (double r in resultados)
            {
                Console.WriteLine(r);
            }
        }
    }
}
