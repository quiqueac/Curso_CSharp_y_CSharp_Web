using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Polimorfismo();
            Console.ReadKey();
        }

        static void Polimorfismo()
        {
            CAnimal miMascota = new CAnimal();
            string valor;
            int opcion;

            Console.Write("¿Qué mascota quieres?: ");
            valor = Console.ReadLine();
            opcion = Convert.ToInt32(valor);

            switch (opcion)
            {
                case 1:
                    miMascota = new CPerro();
                    break;
                case 2:
                    miMascota = new CPez();
                    break;
                case 3:
                    miMascota = new CAve();
                    break;
                default:
                    Console.WriteLine("No existe esa opción.");
                    break;
            }

            Console.Write("Dame el nombre: ");
            miMascota.Nombre = Console.ReadLine();

            miMascota.Moverse();
        }

        static void Casting()
        {
            CProducto p1 = new CProductoImportado("Tele", 2500, 0.15);

            p1.CalculaPrecio();
            Console.WriteLine(p1);

            ((CProductoImportado)p1).Mensaje();

            Console.WriteLine("----------------------");

            CProductoImportado p4 = new CProductoImportado("Balon", 250.50, 0.16);

            Detecta(p1);
            Detecta(p4);
        }

        static void Detecta(CProducto producto)
        {
            if (producto is CProducto)
            {
                Console.WriteLine("== es CProducto");
                producto.CalculaPrecio();
                Console.WriteLine(producto);
            }
            if (producto is CProductoImportado)
            {
                Console.WriteLine("== es CProductoImportado");
                producto.CalculaPrecio();
                ((CProductoImportado)producto).Mensaje();
                Console.WriteLine(producto);
            }
        }

        static void Composicion()
        {
            CEscuela miEscuela = new CEscuela("Hola mundo");

            miEscuela.ColocaAulas();

            Console.WriteLine(miEscuela);

            miEscuela = null;
        }

        static void Virtuales()
        {
            //CProducto uno = new CProducto("Bicicleta", 2500.35);

            //uno.CalculaPrecio();
            //uno.MuestraVenta();

            Console.WriteLine("----------------------");

            CProductoImportado dos = new CProductoImportado("Bicicleta importada", 2500.35, 0.15);

            dos.CalculaPrecio();
            dos.MuestraVenta();

            Console.WriteLine("----------------------");

            CProductoDetenido tres = new CProductoDetenido("Bicicleta importada detenida", 2500.35, 0.15, 500.8);

            tres.CalculaPrecio();
            tres.MuestraVenta();

            Console.WriteLine("----------------------");

            CProducto cuatro = new CProductoImportado("Bicicleta", 2200, 0.2);

            cuatro.CalculaPrecio();
            cuatro.MuestraVenta();

            Console.WriteLine("----------------------");
        }

        static void Agregacion()
        {
            CPropietario juan = new CPropietario("Juan");

            CEdificio edif = new CEdificio("Av. 1 num 56", 10, 3);

            juan.MostrarPropiedad();

            juan.AdicionaPropiedad(edif);
            juan.MostrarPropiedad();

            juan = null;
            edif.Muestra();
        }

        static void CursoF()
        {
            CPersona uno = new CPersona("María", 27);

            uno.Muestra();
            Console.WriteLine("----------------------");

            uno.Edad = 15;

            CEmpleado dos = new CEmpleado("Juan", 30, "Contador", 10500.50);

            dos.EmpleadoMuestra();
            Console.WriteLine("----------------------");
        }

        static void CursoE()
        {
            CComputadora compu1 = new CComputadora();
            CComputadora compu2 = new CComputadora("i5", 4, 450);
            CComputadora compu3 = new CComputadora("i7", 8, 670);

            compu1.TipoCambio = 15.70;

            // Mostramos
            compu1.MuestraDolares();
            compu1.MuestraPesos();
            Console.WriteLine("----------------------");

            compu1.TipoCambio = 1.00;

            compu1.MuestraDolares();
            compu1.MuestraPesos();
        }

        static void CursoD()
        {
            string nombre;
            string tempEdad;
            int edad;

            Console.Write("Dame el nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Dame la edad: ");
            tempEdad = Console.ReadLine();

            Console.WriteLine();

            edad = Convert.ToInt32(tempEdad);

            CPersona persona = new CPersona(nombre, edad);

            persona.Muestra();
        }

        static void CursoC()
        {
            int rInt = 0;
            double rDoub = 0;

            CCalculadoraA calcu = new CCalculadoraA();

            rInt = calcu.Suma(5, 3);

            Console.WriteLine("El resultado es {0}", rInt);

            rDoub = calcu.Suma(10.58, 23.17);

            Console.WriteLine("El resultado es {0}", rDoub);
        }

        static void CursoB()
        {
            //double impuesto = 0.0;

            // Creamos objeto
            CEmpleado Juan = new CEmpleado();

            // No podemos hacer esto
            //Juan.sueldo = 10000;

            Juan.Sueldo = 15000;
            Juan.CalculaImpuesto();

            Console.WriteLine("El impuesto de Juan es {0}", Juan.Impuesto);

            Juan.Muestra();
        }

        static void CursoA()
        {
            // Creamos instancia
            CCalculadora calcu1 = new CCalculadora();

            // Accedemos a los atributos para colocar información
            calcu1.a = 5;
            calcu1.b = 3;

            // Intento de acceder al dato privado
            // No se puede
            //calcu1.r = 8;
            //Console.WriteLine(calcu1.r);

            // Mostramos los datos (pero ya no, porque es privado)
            //calcu1.Muestra();

            // Invocamos método
            calcu1.Suma();

            // Mostramos nuevamente los datos (pero ya no, porque es privado)
            //calcu1.Muestra();

            //--------
            Console.WriteLine("----------------------");

            // Creamos otro objeto y asignamos valores
            CCalculadora miCalcu = new CCalculadora();

            miCalcu.a = 18;
            miCalcu.b = 53;

            miCalcu.Suma();

            // Comprobamos que cada objeto tiene su información (pero ya no, porque es privado)
            //calcu1.Muestra();
            //miCalcu.Muestra();
        }
    }
}
