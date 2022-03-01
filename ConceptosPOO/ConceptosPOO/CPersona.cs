using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosPOO
{
    class CPersona
    {
        protected string nombre;
        protected int edad;

        public CPersona()
        {
            nombre = "";
            edad = 0;
        }

        public CPersona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public int Edad
        {
            get
            {
                return edad;
            }
            set
            {
                if (value >= 18)
                {
                    edad = value;
                }
                else
                {
                    edad = -1;
                    Console.WriteLine("Edad no permitida");
                }
            }
        }

        public void Muestra()
        {
            Console.WriteLine("Nombre: {0}, edad: {1}", nombre, edad);
        }
        ~CPersona()
        {
        }
    }
}
