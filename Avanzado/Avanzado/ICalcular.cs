using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanzado
{
    interface ICalcular : IMostrar
    {
        int Calculo(int a, int b);
    }
}
