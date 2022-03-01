using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanzado
{
    class CReal
    {
        private double r;

        public double R { get { return r; } set { r = value; } }

        public CReal()
        {

        }

        public CReal(double r)
        {
            this.r = r;
        }

        public override string ToString()
        {
            return string.Format("r = {0}", r);
        }

        public static implicit operator CComplejo(CReal r)
        {
            CComplejo temporal = new CComplejo((int)r.r, 0);
            return temporal;
        }
    }
}
