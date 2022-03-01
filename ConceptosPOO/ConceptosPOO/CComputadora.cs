using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosPOO
{
    class CComputadora
    {
        private static double tipoCambio;

        private string procesador;
        private int memoria;
        private double costo;

        public CComputadora()
        {
            procesador = "i3";
            memoria = 2;
            costo = 350;
        }

        public CComputadora(string procesador, int memoria, double costo)
        {
            this.procesador = procesador;
            this.memoria = memoria;
            this.costo = costo;
        }

        public double TipoCambio
        {
            set
            {
                tipoCambio = value;
            }
        }

        public void MuestraDolares()
        {
            Console.WriteLine("Procesador: {0}, memoria: {1}", procesador, memoria);
            Console.WriteLine("Costo $USD: {0}", costo);
        }

        public void MuestraPesos()
        {
            Console.WriteLine("Procesador: {0}, memoria: {1}", procesador, memoria);
            Console.WriteLine("Costo $: {0}, TC: {1}", costo * tipoCambio, tipoCambio);
        }
    }
}
