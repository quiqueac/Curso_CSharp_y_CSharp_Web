using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ASP.Models
{
    public enum ResultadoOperacion
    {
        Aprobado = 1,
        Rechazado = 2,
        Pendiente = 7,
        [Description("Pendiente enumeración")]
        PendienteAprobacion = 9
    }
}