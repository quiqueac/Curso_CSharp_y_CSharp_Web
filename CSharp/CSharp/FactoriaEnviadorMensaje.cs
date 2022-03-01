using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    static class FactoriaEnviadorMensaje
    {
        public static IEnviadorMensaje Factoria(string parametro)
        {
            if (parametro == "sms")
            {
                return new EnviarMiniMensaje();
            }
            else if (parametro == "correo")
            {
                return new EnviarCorreo();
            }

            throw new ApplicationException();
        }
    }
}
