using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MisMates;

namespace Intermedio
{
    public delegate void MiDelegado(string m);

    class Program
    {
        static void Main(string[] args)
        {
            double r;

            r = CMates.Suma(5.4, 3.2);

            Console.WriteLine(r);

            Console.ReadKey();
        }

        static void SobrecargaOperadores()
        {
            CImaginario im1 = new CImaginario(1, 2);
            CImaginario im2 = new CImaginario(3, 4);
            CImaginario imr;

            imr = im1 + im2;

            Console.WriteLine("{0} + {1} = {2}", im1, im2, imr);

            imr = im1 - im2;

            Console.WriteLine("{0} - {1} = {2}", im1, im2, imr);

            imr = im1 * im2;

            Console.WriteLine("{0} * {1} = {2}", im1, im2, imr);

            imr = im1 / im2;

            Console.WriteLine("{0} / {1} = {2}", im1, im2, imr);

            Console.WriteLine(im1);
            im1++;
            Console.WriteLine(im1);

            Console.WriteLine("------------------------------");

            Console.WriteLine(im2);
            im2--;
            Console.WriteLine(im2);

            Console.WriteLine("------------------------------");

            Console.WriteLine(im1);
            im1 += im2;
            Console.WriteLine(im1);

            Console.WriteLine("------------------------------");

            if (im1 == imr)
            {
                Console.WriteLine("Son iguales");
            }
            else
            {
                Console.WriteLine("Son diferentes");
            }

            Console.WriteLine("------------------------------");

            if (im1 == imr)
            {
                Console.WriteLine("Son iguales");
            }
            if (im2 != im1)
            {
                Console.WriteLine("Son diferentes");
            }
            if (im1 < imr)
            {
                Console.WriteLine("im1 es menor");
            }
            if (im2 > im1)
            {
                Console.WriteLine("im2 es menor");
            }
        }

        static void Indexer()
        {
            CTiendaAutos miTienda = new CTiendaAutos();

            CAuto miAuto = miTienda[1];
            miAuto.MuestraInformacion();

            CAuto otroAuto = new CAuto("Vocho", 85000);
            miTienda[1] = otroAuto;

            for (int i = 0; i < 4; i++)
            {
                miTienda[i].MuestraInformacion();
            }
        }

        static void Delegados()
        {
            MiDelegado delegado = new MiDelegado(CRadio.MetodoRadio);

            delegado("Hola a todos");

            delegado = new MiDelegado(CPastel.MostrarPastel);

            delegado("Feliz cumpleaños");

            Console.WriteLine("---------------------------");

            CRefrigerador refrigerador = new CRefrigerador(70, -20);
            Random random = new Random();

            DReservasBajas kilos1 = new DReservasBajas(InformeKilos);
            DReservasBajas kilos2 = new DReservasBajas(CTienda.MandaViveres);

            DDescongelado desc1 = new DDescongelado(InformeGrados);


            // handlers
            refrigerador.AdicionaMetodoReservas(kilos1);
            refrigerador.AdicionaMetodoReservas(kilos2);
            refrigerador.AdicionaMetodoDescongelado(desc1);

            // el refrigerador trabaja
            while (refrigerador.Kilos > 0)
            {
                refrigerador.Trabajar(random.Next(1, 5));
            }

            refrigerador.EliminaMetodoReservas(kilos2);

            refrigerador.Kilos = 50;
            refrigerador.Grados = -15;

            while (refrigerador.Kilos > 0)
            {
                refrigerador.Trabajar(random.Next(1, 5));
            }
        }

        public static void InformeKilos(int kilos)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-->Reservas bajas de alimentos, estoy a nivel de main");
            Console.WriteLine("-->Quedan {0} kilos", kilos);
        }

        public static void InformeGrados(int grados)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("--->Se descongela el refri!, estoy a nivel de main");
            Console.WriteLine("--->Esta a {0} grados", grados);
        }

        static void InterfacesPredefinidas()
        {
            CTiendaAutos tienda = new CTiendaAutos();

            foreach (CAuto miAuto in tienda)
            {
                miAuto.CalculaTenencia(0.05);
                miAuto.MuestraInformacion();
            }

            CContenedora datos = new CContenedora();

            foreach (int valor in datos)
            {
                Console.WriteLine(valor);
            }

            Console.WriteLine("---------------------------");

            CRectangulo[] rects = new CRectangulo[5];

            rects[0] = new CRectangulo(7, 5);
            rects[1] = new CRectangulo(6, 4);
            rects[2] = new CRectangulo(4, 3);
            rects[3] = new CRectangulo(7, 6);
            rects[4] = new CRectangulo(5, 7);

            foreach (CRectangulo r in rects)
            {
                Console.WriteLine(r);
            }

            Console.WriteLine("---------------------------");

            Array.Sort(rects);

            foreach (CRectangulo r in rects)
            {
                Console.WriteLine(r);
            }
        }

        static void Interfaces()
        {
            int opcion;
            double valA;
            double valB;
            string valor;

            IOperacion operacion = new CSuma();

            do
            {
                Console.WriteLine("1-suma, 2-resta, 3-multiplicación, 4-división, 5-salir");
                Console.Write("¿Qué opción deseas?: ");
                valor = Console.ReadLine();
                opcion = Convert.ToInt32(valor);

                Console.Write("Dame el valor de a: ");
                valor = Console.ReadLine();
                valA = Convert.ToDouble(valor);

                Console.Write("Dame el valor de b: ");
                valor = Console.ReadLine();
                valB = Convert.ToDouble(valor);

                switch (opcion)
                {
                    case 1:
                        operacion = new CSuma();
                        break;
                    case 2:
                        operacion = new CResta();
                        break;
                    case 3:
                        operacion = new CMultiplicacion();
                        break;
                    case 4:
                        operacion = new CDivision();
                        break;
                    default:
                        break;
                }

                operacion.Calcular(valA, valB);
                operacion.Mostrar();
            } while (opcion != 5);
        }
    }
}
