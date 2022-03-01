using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Gato: Animal
    {
        public Gato(string nombre)
        {
            this.nombre = nombre;
        }

        public override void HacerRuido()
        {
            Console.WriteLine("{0} dice miaaau", nombre);
        }
    }
}
