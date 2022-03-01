using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermedio
{
    class CTiendaAutos
    {
        private CAuto[] disponibles;

        public CTiendaAutos()
        {
            disponibles = new CAuto[4];

            disponibles[0] = new CAuto("Soul", 220000.50);
            disponibles[1] = new CAuto("Fit", 175600.70);
            disponibles[2] = new CAuto("March", 168900.00);
            disponibles[3] = new CAuto("Spark", 160400.40);
        }

        public IEnumerator GetEnumerator()
        {
            return disponibles.GetEnumerator();
        }

        public CAuto this[int indice]
        {
            get
            {
                return disponibles[indice];
            }
            set
            {
                disponibles[indice] = value;
            }
        }
    }
}
