using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Vector
    {
        private List<int> _componentes;

        public Vector(List<int> componentes)
        {
            _componentes = componentes;
        }

        public List<int> Componentes
        {
            get
            {
                return _componentes;
            }
        }

        public static Vector operator +(Vector v1, Vector v2)
        {
            return v1.Suma(v2);
        }

        public Vector Suma(Vector v2)
        {
            if(Dimension != v2.Dimension)
            {
                throw new ApplicationException("Las dimensiones no son iguales");
            }

            List<int> resultado = new List<int>();

            for(int i = 0; i < Dimension; i++)
            {
                resultado.Add(this[i] + v2[i]);
            }

            return new Vector(resultado);
        }

        public int this[int i]
        {
            get
            {
                return _componentes[i];
            }
            set
            {
                _componentes[i] = value;
            }
        }

        public int Dimension
        {
            get
            {
                return _componentes.Count;
            }
        }

        public string Nombre
        {
            get;
            set;
        }
    }
}
