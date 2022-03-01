using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermedio
{
    class CContenedora : IEnumerable
    {
        private int[] valores = new int[10];

        public CContenedora()
        {
            for (int n = 0; n < 10; n++)
            {
                valores[n] = n * n;
            }
        }

        public IEnumerator GetEnumerator()
        {
            return (new ContenedorEnum(valores));
        }
    }
}
