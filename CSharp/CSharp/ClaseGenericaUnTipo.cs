using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class ClaseGenericaUnTipo<T>
    {
        public List<T> MiLista { get; set; }

        public ClaseGenericaUnTipo()
        {
            MiLista = new List<T>();
        }

        public void Agregar(T valor)
        {
            MiLista.Add(valor);
        }
    }
}
