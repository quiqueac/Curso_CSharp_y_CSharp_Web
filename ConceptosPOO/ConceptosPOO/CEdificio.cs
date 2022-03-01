using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosPOO
{
    class CEdificio
    {
        private string direccion;
        private int cantDepartamentos;
        private int depRentados;

        public CEdificio(string direccion, int cantDepartamentos, int depRentados)
        {
            this.direccion = direccion;
            this.cantDepartamentos = cantDepartamentos;
            this.depRentados = depRentados;
        }

        public void Muestra()
        {
            Console.WriteLine("Edificio en {0} con {1} departamentos, {2} rentados", direccion, cantDepartamentos, depRentados);
        }
    }
}
