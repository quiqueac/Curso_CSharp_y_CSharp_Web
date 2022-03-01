using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosPOO
{
    class CAula
    {
        private string nombreAula;
        private int cantidadAlumnos;

        public CAula(string nombreAula, int cantidadAlumnos)
        {
            this.nombreAula = nombreAula;
            this.cantidadAlumnos = cantidadAlumnos;
        }

        public override string ToString()
        {
            string mensaje = string.Format("El aula {0}, tiene {1} alumnos", nombreAula, cantidadAlumnos);
            return mensaje;
        }
    }
}
