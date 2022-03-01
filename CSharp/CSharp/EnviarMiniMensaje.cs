using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class EnviarMiniMensaje: IEnviadorMensaje
    {
        public void EnviarMensaje(string mensaje)
        {
            Console.WriteLine("Enviando minimensaje: " + mensaje);
        }

        public string CualquierMetodo()
        {
            return "Lo que sea";
        }
    }
}
