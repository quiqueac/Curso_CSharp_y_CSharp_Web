using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Ventana
    {
        private int ancho;
        private int altura;
        private string color;

        public Ventana()
        {
            ancho = 15;
            altura = 20;
            color = "Rojo";
        }

        public void Mostrar()
        {
            Console.Write("Hola usuario");
        }

        ~Ventana()
        {
            System.Diagnostics.Trace.WriteLine("Se destruyeron los recursos");
        }
    }
}
