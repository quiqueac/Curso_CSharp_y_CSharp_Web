using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosPOO
{
    class CEscuela
    {
        private string nombre;
        private CAula[] aulas = new CAula[3];

        public CEscuela(string nombre)
        {
            this.nombre = nombre;
        }

        public void ColocaAulas()
        {
            int n = 0;
            string dato = "";
            string nombre = "";
            int cantidad = 0;

            for(n = 0; n < aulas.Length; n++)
            {
                Console.Write("Dame el nombre de aula: ");
                nombre = Console.ReadLine();
                Console.Write("Dame la cantidad de alumnos: ");
                dato = Console.ReadLine();
                cantidad = Convert.ToInt32(dato);

                aulas[n] = new CAula(nombre, cantidad);
            }
        }

        public override string ToString()
        {
            string mensaje = "";
            int n = 0;

            mensaje = string.Format("Bienvenidos a la escuela {0}, la cual consta de:\n\r", nombre);

            for (n = 0; n < aulas.Length; n++)
            {
                mensaje += aulas[n].ToString() + "\r\n";
            }

            return mensaje;
        }
    }
}
