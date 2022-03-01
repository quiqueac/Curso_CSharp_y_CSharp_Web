using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosPOO
{
    class CProductoDetenido: CProductoImportado
    {
        private double multa;

        public CProductoDetenido(string descripcion, double precioCompra, double impuesto, double multa) : base(descripcion, precioCompra, impuesto)
        {
            this.multa = multa;
        }

        // Si esta sellada, alguna clase hija no podrá sobrecargar este método, pero si usarlo por herencia
        public sealed override void CalculaPrecio()
        {
            Console.WriteLine("Calcula precio de importado con multa");
            precioVenta = ((precioCompra * (1 + impuesto)) * 1.30) + multa;
        }
    }
}
