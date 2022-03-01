using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosPOO
{
    class CReptil: CAnimal
    {
        public override void Moverse()
        {
            Console.WriteLine("El reptil {0} se arrastra.", nombre);
        }
    }
}
