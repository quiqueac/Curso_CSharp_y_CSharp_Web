using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Perro: Animal
    {
        public Perro(string nombre)
        {
            this.nombre = nombre;
        }

        public override void HacerRuido()
        {
            Console.WriteLine("{0} dice woof", nombre);
        }

        public void ElBaile()
        {
            Console.WriteLine("{0} ha bailado", nombre);
        }
    }
}
