using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanzado
{
    class CPunto<T>
    {
        public delegate void DelMensaje();

        public DelMensaje mensaje;

        private T x;
        private T y;

        public CPunto(T px, T py)
        {
            x = px;
            y = py;
        }

        public override string ToString()
        {
            return string.Format("X = {0}, Y = {1}", x, y);
        }

        public void Reset()
        {
            x = default(T);
            y = default(T);
        }

        public void EncuetraTipo()
        {
            if (typeof(T) == typeof(int))
            {
                Console.WriteLine("Trabajo como entero");
            }
            else
            {
                Console.WriteLine("Soy de otro tipo");
            }
        }
    }
}
