using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosPOO
{
    class CGato: CAnimal
    {
        public override void Moverse()
        {
            Console.WriteLine("El gato {0} camina.", nombre);
        }
    }
}
