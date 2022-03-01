using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanzado
{
    class CTelevisor : IElectronico
    {
        string marca;

        public CTelevisor(string marca)
        {
            this.marca = marca;
        }

        public override string ToString()
        {
            return string.Format("El televisor es marca {0}", marca);
        }

        public void Encender(bool interruptor)
        {
            if (interruptor)
            {
                Console.WriteLine("Encendido");
            }
            else
            {
                Console.WriteLine("Apagado");
            }
        }
    }
}
