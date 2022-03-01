using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Oveja: Animal
    {
        public Oveja(string nombre)
        {
            this.nombre = nombre;
        }

        public override void HacerRuido()
        {
            Console.WriteLine("{0} dice veeeh", nombre);
        }

        public void Trasquilar()
        {
            Console.WriteLine("{0} ha sido trasquilada", nombre);
        }
    }
}
