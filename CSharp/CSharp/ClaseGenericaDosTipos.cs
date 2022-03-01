using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class ClaseGenericaDosTipos<T, M>
    {
        public List<T> MiListaDeT { get; set; }
        public List<M> MiListaDeM { get; set; }

        public ClaseGenericaDosTipos()
        {
            MiListaDeT = new List<T>();
            MiListaDeM = new List<M>();
        }

        public void Agregar(T valorT, M valorM)
        {
            MiListaDeT.Add(valorT);
            MiListaDeM.Add(valorM);
        }
    }
}
