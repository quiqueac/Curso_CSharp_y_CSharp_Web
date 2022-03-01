using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermedio
{
    class ContenedorEnum : IEnumerator
    {
        private int[] valores;
        private int posicion = -1;

        public object Current
        {
            get
            {
                return valores[posicion];
            }
        }

        public ContenedorEnum(int[] valores)
        {
            this.valores = valores;
        }

        public bool MoveNext()
        {
            posicion++;
            if (posicion < valores.Length)
            {
                return true;
            }
            return false;
        }

        public void Reset()
        {
            posicion = -1;
        }
    }
}
