using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermedio
{
    delegate void DReservasBajas(int kilos);
    delegate void DDescongelado(int grados);

    class CRefrigerador
    {
        private int kilos;
        private int grados;

        // Variables para invocar
        private DReservasBajas delReservas;
        private DDescongelado delDescongelado;

        public CRefrigerador(int kilos, int grados)
        {
            this.kilos = kilos;
            this.grados = grados;
        }

        // Métodos para referenciar las variables
        public void AdicionaMetodoReservas(DReservasBajas metodo)
        {
            delReservas += metodo;
        }

        public void EliminaMetodoReservas(DReservasBajas metodo)
        {
            delReservas -= metodo;
        }

        public void AdicionaMetodoDescongelado(DDescongelado metodo)
        {
            delDescongelado += metodo;
        }

        public int Kilos { get { return kilos; } set { kilos = value; } }

        public int Grados { get { return grados; } set { grados = value; } }

        public void Trabajar(int consumo)
        {
            kilos -= consumo;

            grados += 1;

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("{0} kilos, {1} grados", kilos, grados);

            if (kilos < 10)
            {
                delReservas(kilos);
            }
            if (grados > 0)
            {
                delDescongelado(grados);
            }
        }
    }
}
