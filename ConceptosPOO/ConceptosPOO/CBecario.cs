using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosPOO
{
    class CBecario: CPersona
    {
        private int horasBeca;

        public CBecario(string nombre, int edad, int hora): base(nombre, edad)
        {
            horasBeca = hora;
        }

        public int HorasBeca
        {
            get
            {
                return horasBeca;
            }
            set
            {
                horasBeca = value;
            }
        }

        public void MuestraBecario()
        {
            Console.WriteLine("Cantidad de horas: {0}", horasBeca);
        }
    }
}
