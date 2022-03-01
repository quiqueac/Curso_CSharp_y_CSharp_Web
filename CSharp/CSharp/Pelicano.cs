using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Pelicano: Animal
    {
        public Pelicano(string nombre)
        {
            this.nombre = nombre;
        }

        public override void HacerRuido()
        {
            base.HacerRuido();
        }
    }
}
