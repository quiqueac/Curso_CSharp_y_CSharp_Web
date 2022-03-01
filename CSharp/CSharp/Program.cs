using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            ArreglosBididimensionales();
        }

        static void ArreglosBididimensionales()
        {
            int[,] matriz = new int[2, 2];

            matriz[0, 0] = 1;
            matriz[0, 1] = 2;
            matriz[1, 0] = 3;
            matriz[1, 1] = 4;

            int[,] matrizA = new int[2, 2]
            {
                {1,2}, {3,4}
            };

            Console.WriteLine(matriz[1, 1]);

            string[,] matrizB = new string[3, 2]
            {
                {"Valor1", "Valor2"},
                {"Valor3", "Valor4"},
                {"Valor5", "Valor6"},
            };

            EscribirArregloBidimensionalEnPantalla(matrizA);

            Console.ReadKey();
        }

        public static void EscribirArregloBidimensionalEnPantalla(int[,] matriz)
        {
            var filas = matriz.GetLength(0);
            var columnas = matriz.GetLength(1);
            var sb = new StringBuilder();
            var tmpFila = new int[matriz.GetLength(0)];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    tmpFila[j] = matriz[i, j];
                }
                sb.Append(string.Join("\t", tmpFila));
                sb.Append("");
            }

            Console.WriteLine(sb.ToString());
        }

        static void Arreglos()
        {
            int[] arregloDeNumeros = new int[3];

            arregloDeNumeros[0] = 5;
            arregloDeNumeros[1] = -50;
            arregloDeNumeros[2] = 100;

            string[] arregloDeString = new string[] { "Felipe", "C#", "Javascript", "...", "PROBLEMA" };
            arregloDeString[4] = "Python";

            Array.Resize(ref arregloDeString, 6);
            arregloDeString[5] = "Magneto";

            Console.ReadKey();
        }

        static void FIFOQueues()
        {
            Queue<string> queue = new Queue<string>();

            Console.Write("Primer elemento insertado: ");
            Console.WriteLine("Primero");
            queue.Enqueue("Primero");

            Console.Write("Segundo elemento insertado: ");
            Console.WriteLine("Segundo");
            queue.Enqueue("Segundo");

            Console.Write("Tercer elemento insertado: ");
            Console.WriteLine("Tercero");
            queue.Enqueue("Tercero");

            Console.WriteLine();

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.Write("Primer elemento extraído: ");
            Console.WriteLine(queue.Dequeue());

            Console.Write("Segundo elemento extraído: ");
            Console.WriteLine(queue.Dequeue());

            Console.Write("Tercer elemento extraído: ");
            Console.WriteLine(queue.Dequeue());

            Console.ReadKey();
        }

        static void Diccionario()
        {
            Dictionary<string, int> NombreEdad = new Dictionary<string, int>();
            NombreEdad.Add("Felipe", 85);
            NombreEdad.Add("Roberto", 40);
            NombreEdad.Add("María", 40);

            Console.WriteLine(NombreEdad["Roberto"]);

            if (NombreEdad.ContainsKey("María"))
            {
                Console.WriteLine("María");
            }

            NombreEdad.Remove("Roberto");

            foreach (var keys in NombreEdad.Keys)
            {
                Console.WriteLine(keys);
            }

            Console.ReadKey();
        }

        static void ColeccionesArreglos()
        {
            List<string> nombres = new List<string>();
            nombres.Add("Felipe");
            nombres.Add("Mario");
            nombres.Add("5");

            List<int> numeros = new List<int>() { 1, 5, 7, 8, -3, 6, 2, 4, 6 };

            numeros.Add(0);

            numeros.Remove(2);
            numeros.RemoveAt(1);
            numeros.RemoveAt(numeros.Count - 1);

            numeros.Insert(0, 100);
            numeros.Insert(4, -100);

            var primerElementoDeLaLista = numeros[0];
            var ultimoElementoDeLaLista = numeros[numeros.Count - 1];
        }

        static void ClasesGenericas()
        {
            ClaseGenericaUnTipo<decimal> miColeccionDecimal = new ClaseGenericaUnTipo<decimal>();
            miColeccionDecimal.Agregar(9);
            ClaseGenericaUnTipo<string> miColeccionString = new ClaseGenericaUnTipo<string>();
            miColeccionString.Agregar("Enrique");

            ClaseGenericaDosTipos<decimal, string> misColecciones = new ClaseGenericaDosTipos<decimal, string>();
            misColecciones.Agregar(20m, "Enrique");
        }

        static void OutRef()
        {
            /*
             * out es para pasar por referencia, pero se requiere inicializarlo
             * en el método al cual fue pasado.
             * ref no requiere nada.
             */
        }

        static void MetodosGenericos()
        {
            var persona1 = new Persona { Nombre = "Felipe" };
            var xml_persona1 = Serializar<Persona>(persona1);

            var persona2 = new Persona { Nombre = "Carla" };
            var xml_persona2 = Serializar(persona2);

            var empresa1 = new Empresa { Direccion = "Avenida Siempre Viva 123" };
            var xml_empresa1 = Serializar(empresa1);
            Console.ReadKey();
        }

        private static string Serializar<T>(T valor)
        {
            var serializador = new XmlSerializer(typeof(T));

            using (var escritorString = new StringWriter())
            {
                using (var escritor = XmlWriter.Create(escritorString))
                {
                    serializador.Serialize(escritor, valor);
                    return escritorString.ToString();
                }
            }
        }

        static void InyeccionDependenciaFactorias()
        {
            var enviadorMensajeDependencia = FactoriaEnviadorMensaje.Factoria("sms");
            var enviadorMensaje = new EnviadorMensaje(enviadorMensajeDependencia);
            enviadorMensaje.EnviarMensaje("Mini mensaje");
            enviadorMensajeDependencia = FactoriaEnviadorMensaje.Factoria("correo");
            enviadorMensaje = new EnviadorMensaje(enviadorMensajeDependencia);
            enviadorMensaje.EnviarMensaje("Mensaje de correo");
            Console.ReadKey();
        }

        static void Interfaces()
        {
            var miniMensaje = new EnviarMiniMensaje();
            var enviarCorreo = new EnviarCorreo();

            Enviar(miniMensaje, "prueba");
            Enviar(enviarCorreo, "pruebaA");

            Console.ReadKey();
        }

        public static void Enviar(IEnviadorMensaje mensajero, string mensaje)
        {
            mensajero.EnviarMensaje(mensaje);
        }

        static void Polimorfismo()
        {
            Animal perro = new Perro("Jorge");
            Animal gato = new Gato("Sebastian");
            Animal pelicano = new Pelicano("Mildred");
            Animal gusano = new Gusano("Jorgito");

            AnimalHacerRuido(perro);
            AnimalHacerRuido(gato);
            AnimalHacerRuido(pelicano);
            AnimalHacerRuido(gusano);

            Console.ReadKey();
        }
        public static void AnimalHacerRuido(Animal animal)
        {
            animal.HacerRuido();
        }
        static void Herencia()
        {
            List<Animal> animales = new List<Animal>();
            animales.Add(new Vaca("Roberto"));
            animales.Add(new Oveja("Mario"));

            foreach(var animal in animales)
            {
                animal.HacerRuido();
            }

            Console.ReadKey();
        }
        static void Encapsulamiento()
        {
            var iteradorDeLista = new IteradorDeLista();
            iteradorDeLista.Lista = new List<int>() { 1, 2, 3 };

            //iteradorDeLista.Lista = null;
            iteradorDeLista.EscribirLista();

            Console.ReadKey();
        }
        static void ArgumentosOpcionales(string v1, string v2 = " mundo")
        {
            Console.WriteLine(v1);
            Console.WriteLine(v2);
        }
        static void SobrecargaParams()
        {
            double promedioA;
            int promedioB;

            promedioA = CalcularPromedio(4.5, 5.6, 8.9, 1.7);
            promedioB = CalcularPromedio(5, 7, 9, 2);

            Console.WriteLine(promedioA);
            Console.WriteLine(promedioB);
            Console.ReadKey();
        }

        private static double CalcularPromedio(params double[] numeros)
        {
            double suma = 0;

            foreach(var numero in numeros)
            {
                suma += numero;
            }

            return suma / numeros.Length;
        }

        private static int CalcularPromedio(params int[] numeros)
        {
            int suma = 0;

            foreach (var numero in numeros)
            {
                suma += numero;
            }

            return suma / numeros.Length;
        }

        static void POO()
        {
            var v1 = new Vector(new List<int> { 3, 4 });
            var v2 = new Vector(new List<int> { 1, 2 });
            var vectorSuma = v1.Suma(v2);
            var vectorSumaA = v1 + v2;
            v2.Nombre = "Enrique";
            Console.WriteLine(v2.Nombre);
            Console.WriteLine(v2.Componentes.ToString());
            Console.WriteLine(v2.Dimension);
            v2[0] = 5;
            Console.WriteLine("Indexador");
            Console.WriteLine(v2[0]);
            Console.WriteLine(v2.Componentes[0]);
            Console.ReadKey();
        }

        static void Nullable()
        {
            Ventana ventana = new Ventana();
            ventana = null;

            int? numero = 45;
            numero = null;

            DateTime? fechaDeNacimiento = null;
            fechaDeNacimiento = new DateTime(2015, 1, 1);

            if(numero.HasValue)
            {
                Console.WriteLine("El número tiene valor.");
            }
            if(fechaDeNacimiento.HasValue)
            {
                Console.WriteLine("La fecha tiene valor.");
            }
        }

        static void TryCatch()
        {
            int a = 6;
            int b = 0;
            try
            {
                int c = a / b;
                Console.WriteLine(c);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Ha habido un error. {0}", ex.Message);
            }
            finally
            {
                Console.WriteLine("Siempre se va a ejecutar");
            }
            Console.ReadKey();
        }
        static void Enum()
        {
            int estatusOperacion = 5;

            if(estatusOperacion == (int)EstatusOperacion.Exitoso)
            {
            }
            else
            {
                if(estatusOperacion == (int)EstatusOperacion.ClienteNoEncontrado)
                {
                }
                else
                {
                }
            }
        }
        enum EstatusOperacion
        {
            Exitoso = 1,
            ClienteNoEncontrado = 2,
            ErrorDeSistema = 5
        }
        static void DateTime()
        {
            DateTime fecha = new DateTime(2014, 10, 23);
            DateTime fechaConHora = new DateTime(2005, 4, 23, 9, 30, 45);

            Console.WriteLine(fecha.ToString());
            Console.WriteLine(fecha.ToString("MM/dd/yyyy"));
            Console.WriteLine(fecha.ToString("dd/MM/yyyy"));
            Console.WriteLine(fechaConHora.ToString("dd*MM*yy hh:mm:ss"));
            Console.ReadKey();
        }

        static void OperadoresLogicos()
        {
            /*
             * Operador de negación: !
             * Operador AND: &
             * Operador XOR: ^
             * Operador OR: |
            */
        }

        static void EntradaDatos()
        {
            string salida;
            string nombre;
            int edad;

            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese su edad: ");
            edad = int.Parse(Console.ReadLine());

            salida = string.Format("Su nombre es {0} y tiene {1} años de edad.", nombre, edad);
            Console.WriteLine(salida);
            Console.ReadKey();
        }
        static void Variables()
        {
            //Declaración de variables
            int mes;
            int dia = 8;
            string nombre;
            DateTime fechaEntrada;
            bool procesoTerminado;

            //Inicialización de variables
            mes = 7;
            nombre = "Enrique";
            fechaEntrada = new DateTime();
            procesoTerminado = true;

            Console.WriteLine(mes);
            Console.WriteLine(dia);
            Console.WriteLine(nombre);
            Console.WriteLine(fechaEntrada);
            Console.WriteLine(procesoTerminado);
        }
    }
}
