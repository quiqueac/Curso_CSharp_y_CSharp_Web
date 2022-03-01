using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanzado
{

    public delegate void miDelegado<T>(T p);

    class Program
    {
        static void Main(string[] args)
        {
            ImplementacionExplicitaJerarquia();
            Console.ReadKey();
        }

        private static void ArrayList()
        {
            ArrayList palabras = new ArrayList();
            int r;

            palabras.AddRange(new string[] { "hola", "como", "están?" });

            Console.WriteLine("Cantidad de elementos en el ArrayList es {0}", palabras.Count);

            for (int i = 0; i < palabras.Count; i++)
            {
                Console.Write(" {0}", palabras[i]);
            }

            Console.WriteLine();
            Console.WriteLine("-----------------");

            palabras.Add("Bien y tú?");

            foreach (string palabra in palabras)
            {
                Console.Write(" {0}", palabra);
            }

            Console.WriteLine();
            Console.WriteLine("-----------------");

            ArrayList valores = new ArrayList();

            valores.Add(5);
            valores.Add(7);
            valores.Add(4);

            for (int i = 0; i < valores.Count; i++)
            {
                r = (int)valores[i];
                Console.Write(" {0}", r);
            }

            Console.WriteLine();
            Console.WriteLine("-----------------");

            Console.WriteLine(valores.Contains(5));
            Console.WriteLine(valores.Contains(17));

            Console.WriteLine();
            Console.WriteLine("-----------------");

            valores.Insert(2, 55);

            for (int i = 0; i < valores.Count; i++)
            {
                r = (int)valores[i];
                Console.Write(" {0}", r);
            }

            Console.WriteLine();
            Console.WriteLine("-----------------");

            valores.Remove(55);

            for (int i = 0; i < valores.Count; i++)
            {
                r = (int)valores[i];
                Console.Write(" {0}", r);
            }

            Console.WriteLine();
            Console.WriteLine("-----------------");

            valores.RemoveAt(0);

            for (int i = 0; i < valores.Count; i++)
            {
                r = (int)valores[i];
                Console.Write(" {0}", r);
            }

            Console.WriteLine();
            Console.WriteLine("-----------------");
        }

        private static void MetodosGenericos()
        {
            double m = 78.9;
            double n = 98.6;

            Console.WriteLine("m = {0}, n = {1}", m, n);
            Intercambio<double>(ref m, ref n);
            Console.WriteLine("m = {0}, n = {1}", m, n);

            string o = "Hola ";
            string p = "a todos";

            Console.WriteLine("o = {0}, p = {1}", o, p);
            Intercambio<string>(ref o, ref p);
            Console.WriteLine("o = {0}, p = {1}", o, p);
        }

        private static void Intercambio<T>(ref T m, ref T n)
        {
            T temporal;
            temporal = m;
            m = n;
            n = temporal;
        }

        private static void ClaseGenerica()
        {
            CPunto<int> puntoI = new CPunto<int>(3, 4);
            CPunto<double> puntoD = new CPunto<double>(2.56, 1.87);
            CPunto<float> puntoF = new CPunto<float>(8.98f, 7.69f);

            Console.WriteLine(puntoI);
            Console.WriteLine(puntoD);
            Console.WriteLine(puntoF);

            puntoI.Reset();
            Console.WriteLine(puntoI);

            puntoI.EncuetraTipo();
            puntoD.EncuetraTipo();
        }

        private static void ProblemaClaseGenerica()
        {
            COperaciones<int> miOperacion = new COperaciones<int>();
            COperaciones<string> miOperacionS = new COperaciones<string>();

            Console.WriteLine(miOperacion.Suma(5, 4));
            Console.WriteLine(miOperacionS.Suma("hola", " a todos"));
        }

        private static void DelegadoGenericoAction()
        {
            miDelegado<string> delCadena = new miDelegado<string>(HandlerString);
            delCadena("Hola a todos");

            miDelegado<double> delDoble = new miDelegado<double>(HandlerDouble);
            delDoble(58.7);

            int n = 5;
            string m = "Hola a todos";

            Action<string, int> delAction = new Action<string, int>(RepiteMensaje);

            delAction(m, n);

            int x = 5;
            int y = 9;

            Func<int, int, int> delFunc = new Func<int, int, int>(Suma);

            Console.WriteLine(delFunc(x, y));
        }

        private static int Suma(int arg1, int arg2)
        {
            return arg1 + arg2;
        }

        private static void RepiteMensaje(string arg1, int arg2)
        {
            for (int i = 0; i < arg2; i++)
            {
                Console.WriteLine(arg1);
            }
        }

        private static void HandlerDouble(double p)
        {
            Console.WriteLine("Uso de string como tipo y el valor es {0}", p);
        }

        private static void HandlerString(string p)
        {
            Console.WriteLine("Uso de double como tipo y el valor es {0}", p);
        }

        private static void MetodoAnonimo()
        {
            CPunto<int> miPunto = new CPunto<int>(5, 6);

            miPunto.mensaje += delegate ()
            {
                Console.WriteLine("Estoy desde el método anónimo.");
            };

            Console.WriteLine(miPunto.ToString());

            miPunto.mensaje();

            miPunto.mensaje += delegate ()
            {
                Console.WriteLine("Este es otro método anónimo.");
            };

            miPunto.mensaje();
        }

        private static void Predicado()
        {
            List<int> numeros = new List<int>();

            numeros.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 5, 4, 8, 11, 12, 3, 7, 20 });

            Predicate<int> delegado = new Predicate<int>(Rango);

            List<int> numPares = numeros.FindAll(delegado);

            foreach (int n in numPares)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("-------------------------");

            numeros.RemoveAll(delegado);

            foreach (int n in numeros)
            {
                Console.WriteLine(n);
            }
        }

        private static bool Rango(int n)
        {
            if (n >= 3 && n <= 7)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static void Lamda()
        {
            List<int> numeros = new List<int>();

            numeros.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 5, 4, 8, 11, 12, 3, 7, 20 });

            List<int> numPares = numeros.FindAll(i => (i % 2) == 0);

            foreach (int n in numPares)
            {
                Console.WriteLine(n);
            }

            List<int> numParesA = numeros.FindAll((i) =>
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Un par");
                    return true;
                }
                else
                {
                    Console.WriteLine("Un impar");
                    return false;
                }
            });

            foreach (int n in numParesA)
            {
                Console.WriteLine(n);
            }
        }

        private static void ConversionExplicita()
        {
            CComplejo comp1 = new CComplejo(2, 3);

            // Conversión explícita
            CReal real2 = (CReal)comp1;
            Console.WriteLine(real2);

            CReal r3 = new CReal(3.5);

            CComplejo im2 = r3;

            Console.WriteLine(im2);
        }

        private static void InterfacesMetodos()
        {
            IElectronico[] teles = { new CTelevisor("Charp"), new CTelevisor("Zony"), new CRadio("RCB"), new CTelevisor("Filips") };
            IElectronico aparatoCreado = null;

            for (int i = 0; i < teles.Length; i++)
            {
                Console.WriteLine(teles[i]);
            }

            Console.WriteLine("-----------------");

            CTelevisor miTV = new CTelevisor("Charp TV");
            CRadio miRadio = new CRadio("RCB Radio");

            Muestra(miRadio);
            Muestra(miTV);

            Console.WriteLine("-----------------");

            aparatoCreado = CreaAparato();
            aparatoCreado.Encender(true);
            Console.WriteLine(aparatoCreado);
        }

        private static void Muestra(IElectronico aparato)
        {
            aparato.Encender(true);

            if (aparato is CTelevisor)
            {
                Console.WriteLine("El televisor es {0}", aparato);
            }
            if (aparato is CRadio)
            {
                Console.WriteLine("El radio es {0}", aparato);
            }
        }

        private static IElectronico CreaAparato()
        {
            IElectronico aparato = null;
            string dato;
            int opcion;

            Console.Write("¿Qué desea crear? 1-Tele, 2-Radio: ");
            dato = Console.ReadLine();
            opcion = Convert.ToInt32(dato);

            if (opcion == 1)
            {
                Console.Write("Dame la marca de la tele: ");
                dato = Console.ReadLine();
                aparato = new CTelevisor(dato);
            }
            else
            {
                Console.Write("Dame la marca del radio: ");
                dato = Console.ReadLine();
                aparato = new CRadio(dato);
            }

            return aparato;
        }

        private static void ImplementacionExplicitaJerarquia()
        {
            CCuadrado cuadro = new CCuadrado(5);

            ((IPerimetro)cuadro).Calcular();

            ((IArea)cuadro).Calcular();

            CSuma miSuma = new CSuma();

            miSuma.Calculo(5, 3);

            miSuma.MostrarDatos();
        }
    }
}
