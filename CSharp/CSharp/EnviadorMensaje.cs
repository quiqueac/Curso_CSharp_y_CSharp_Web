using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class EnviadorMensaje
    {
        private IEnviadorMensaje _enviadorMensaje;

        public EnviadorMensaje(IEnviadorMensaje enviadorMensaje)
        {
            _enviadorMensaje = enviadorMensaje;
        }

        public void EnviarMensaje(string mensaje)
        {
            _enviadorMensaje.EnviarMensaje(mensaje);
        }
    }
}
