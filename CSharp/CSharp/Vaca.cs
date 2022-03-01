using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Vaca: Animal
    {

        public Vaca(string nombre)
        {
            this.nombre = nombre;
        }

        public override void HacerRuido()
        {
            Console.WriteLine("{0} dice muuu", nombre);
        }

        public void Limpiar()
        {
            Console.WriteLine("{0} ha sido limpiada", nombre);
        }
    }
}
