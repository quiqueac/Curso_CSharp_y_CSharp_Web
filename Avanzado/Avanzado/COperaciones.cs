using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanzado
{
    class COperaciones<T>
    {
        public T Suma(T a, T b)
        {
            dynamic da = a, db = b;
            return da + db;
        }
    }
}
