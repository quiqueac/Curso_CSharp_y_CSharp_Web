using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermedio
{
    class CImaginario: IComparable
    {
        private double entero;
        private double imaginario;

        public CImaginario(double entero, double imaginario)
        {
            this.entero = entero;
            this.imaginario = imaginario;
        }

        public double Entero { get { return entero; } set { entero = value; } }

        public double Imaginario { get { return imaginario;  } set { imaginario = value; } }

        public override string ToString()
        {
            if (imaginario < 0)
            {
                return string.Format("({0}   {1}i)", entero, imaginario);
            }
            else
            {
                return string.Format("({0} + {1}i)", entero, imaginario);
            }
        }

        public static CImaginario operator +(CImaginario i1, CImaginario i2)
        {
            double re;
            double ri;

            re = i1.Entero + i2.Entero;
            ri = i1.Imaginario + i2.Imaginario;

            CImaginario temp = new CImaginario(re, ri);

            return temp;
        }

        public static CImaginario operator -(CImaginario i1, CImaginario i2)
        {
            double re;
            double ri;

            re = i1.Entero + i2.Entero;
            ri = i1.Imaginario - i2.Imaginario;

            CImaginario temp = new CImaginario(re, ri);

            return temp;
        }

        public static CImaginario operator *(CImaginario i1, CImaginario i2)
        {
            double re;
            double ri;

            re = (i1.Entero * i2.Entero) - (i1.Imaginario * i2.Imaginario);
            ri = (i1.Entero * i2.Imaginario) - (i1.Imaginario * i2.Entero);

            CImaginario temp = new CImaginario(re, ri);

            return temp;
        }

        public static CImaginario operator /(CImaginario i1, CImaginario i2)
        {
            double re;
            double ri;

            re = ((i1.Entero * i2.Entero) + (i1.Imaginario * i2.Imaginario)) / ((i2.Entero * i2.Entero) + (i2.Imaginario * i2.Imaginario));
            ri = ((i1.Imaginario * i2.Entero) - (i1.Entero * i2.Imaginario)) / ((i2.Entero * i2.Entero) + (i2.Imaginario * i2.Imaginario));

            CImaginario temp = new CImaginario(re, ri);

            return temp;
        }

        public static CImaginario operator ++(CImaginario i1)
        {
            CImaginario temp = new CImaginario(i1.Entero + 1, i1.Imaginario + 1);
            return temp;
        }

        public static CImaginario operator --(CImaginario i1)
        {
            CImaginario temp = new CImaginario(i1.Entero - 1, i1.Imaginario - 1);
            return temp;
        }

        public override bool Equals(object obj)
        {
            if (obj is CImaginario)
            {
                CImaginario temp = (CImaginario)obj;

                if (imaginario == temp.Imaginario && entero == temp.Entero)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator ==(CImaginario i1, CImaginario i2)
        {
            return i1.Equals(i2);
        }

        public static bool operator !=(CImaginario i1, CImaginario i2)
        {
            return !(i1.Equals(i2));
        }

        public double Magnitud()
        {
            double m = 0;

            m = Math.Sqrt((entero * entero) + (imaginario * imaginario));

            return m;
        }

        public int CompareTo(object obj)
        {
            if (obj is CImaginario)
            {
                CImaginario temp = (CImaginario)obj;

                if (Magnitud() > temp.Magnitud())
                {
                    return 1;
                }
                if (Magnitud() < temp.Magnitud())
                {
                    return -1;
                }
            }
            return 0;
        }

        public static bool operator <(CImaginario i1, CImaginario i2)
        {
            if (i1.CompareTo(i2) < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator >(CImaginario i1, CImaginario i2)
        {
            if (i1.CompareTo(i2) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
