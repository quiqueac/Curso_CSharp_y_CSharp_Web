using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosPOO
{
    sealed class CEmpleado: CPersona
    {
        private string puesto;
        private double sueldo;
        private double impuesto;

        public CEmpleado()
        {

        }

        public CEmpleado(string nombre, int edad, string puesto, double sueldo): base(nombre, edad)
        {
            Puesto = puesto;
            Sueldo = sueldo;
        }

        public string Puesto
        {
            get
            {
                return puesto;
            }
            set
            {
                puesto = value;
            }
        }

        public double Sueldo
        {
            get
            {
                return sueldo;
            }
            set
            {
                if (value > 5000)
                {
                    sueldo = value;
                }
                else
                {
                    sueldo = 3000;
                }
            }
        }

        public double Impuesto
        {
            get
            {
                return impuesto;
            }
        }

        public void CalculaImpuesto()
        {
            impuesto = sueldo * 0.16;
        }

        public void PonerDatos(string nombre, int edad, string puesto, double sueldo)
        {
            //Nombre = nombre;
            //Edad = edad;
            this.nombre = nombre;
            this.edad = edad;
            this.puesto = puesto;
            this.sueldo = sueldo;
        }

        public void EmpleadoMuestra()
        {
            Muestra();
            Console.WriteLine("Sueldo = {0}, impuesto = {1}, puesto = {2}", sueldo, impuesto, puesto);
        }
    }
}
