using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanzado
{
    class CSuma: ICalcular
    {
        private int a;
        private int b;
        private int r;

        public int Calculo(int a, int b)
        {
            this.a = a;
            this.b = b;
            r = a + b;

            return r;
        }

        public void MostrarDatos()
        {
            Console.WriteLine("{0} + {1} = {2}", a, b, r);
        }
    }
}
