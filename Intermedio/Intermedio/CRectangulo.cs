using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermedio
{
    class CRectangulo : IComparable
    {
        private double ancho;
        private double alto;
        private double area;

        public CRectangulo(double ancho, double alto)
        {
            this.ancho = ancho;
            this.alto = alto;
            CalculaArea();
        }

        private void CalculaArea()
        {
            area = ancho * alto;
        }

        public override string ToString()
        {
            return string.Format("[{0}, {1} = {2}]", ancho, alto, area);
        }

        public int CompareTo(object obj)
        {
            CRectangulo temp = (CRectangulo)obj;

            if (area > temp.area)
            {
                return 1;
            }
            if (area < temp.area)
            {
                return -1;
            }

            return 0;
        }
    }
}
