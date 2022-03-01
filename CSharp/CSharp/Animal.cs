using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    abstract class Animal
    {
        public string nombre { get; set; }

        public virtual void HacerRuido()
        {
            Console.WriteLine("{0} hace ruido", nombre);
        }
    }
}
