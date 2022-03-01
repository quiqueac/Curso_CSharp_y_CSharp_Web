using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class IteradorDeLista
    {
        private List<int> _lista;

        public IteradorDeLista()
        {
            _lista = new List<int>();
        }

        public List<int> Lista
        {
            get
            {
                return _lista;
            }
            set
            {
                if (value != null)
                {
                    _lista = value;
                }
                else
                {
                    Lista = new List<int>();
                }
            }
        }
        public void EscribirLista()
        {
            if(_lista == null)
            {
                return;
            }
            foreach(var item in _lista)
            {
                Console.WriteLine(item);
            }
        }
    }
}
