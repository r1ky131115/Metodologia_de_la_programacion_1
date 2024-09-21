using Metodologías_de_Programación_I.Clases;
using Metodologías_de_Programación_I.Clases.Factory;
using Metodologías_de_Programación_I.Clases.Iteradores;
using Metodologías_de_Programación_I.Interfaces;
using IComparable = Metodologías_de_Programación_I.Interfaces.IComparable;

namespace Metodologías_de_Programación_I
{
    public static class Helper
    {
        public static string GetNombre()
        {
            List<string> nombres = new List<string>();
            nombres.Add("Jose");
            nombres.Add("Roberto");
            nombres.Add("Antonio");
            nombres.Add("Martin");
            nombres.Add("Rodolfo");
            nombres.Add("Miguel");
            nombres.Add("Joaquin");
            nombres.Add("Valentin");
            nombres.Add("Ramiro");
            nombres.Add("Nahuel");
            nombres.Add("Lisandro");
            nombres.Add("Agustina");
            nombres.Add("Josefina");
            nombres.Add("Maria");
            nombres.Add("Eugenia");
            nombres.Add("Emilia");
            nombres.Add("Andrea");
            nombres.Add("Susana");
            nombres.Add("Marta");
            nombres.Add("Mirta");
            nombres.Add("Cristina");
            nombres.Add("Amalia");
            return nombres[new Random().Next(nombres.Count - 1)];
        }

        public static void Llenar(IColeccionable coleccoinable)
        {
            for (int i = 0; i < 20; i++)
            {
                IComparable comparable = new Numero(new Random().Next());
                coleccoinable.Agregar(comparable);
            }
        }

        public static void LlenarPersonas(IColeccionable coleccionable)
        {
            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                string nombreAleatorio = GetNombre();
                int dniAleatorio = random.Next(10000000, 99999999);
                Persona persona = new Persona(nombreAleatorio, dniAleatorio);
                coleccionable.Agregar(persona);
            }
        }

        public static void LlenarAlumnos(IColeccionable coleccionable)
        {
            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                string nombreAleatorio = GetNombre();
                int dniAleatorio = random.Next(10000000, 99999999);
                int legajoAleatorio = random.Next(1000, 9999); 
                double promedioAleatorio = Math.Round(random.NextDouble() * 10, 2);

                Alumno alumno = new Alumno(nombreAleatorio, dniAleatorio, legajoAleatorio, promedioAleatorio, null);
                coleccionable.Agregar(alumno);
            }
        }

        public static void Informar(IColeccionable coleccionable)
        {
            Console.WriteLine("El más grande de la coleccion es {0} ", coleccionable.Maximo());
            Console.WriteLine("El más chico de la coleccion es {0} ", coleccionable.Minimo());
            Console.WriteLine("La cantidad de elementos de la cola es {0}", coleccionable.Cuantos());

            //IComparable comparable = new Numero(new Random().Next());

            //if (coleccionable.Contiene(comparable))
            //{
            //    Console.WriteLine($"El elemento '{comparable.ToString()}' esta en la colección.");
            //}
            //else
            //{
            //    Console.WriteLine($"El elemento '{comparable.ToString()}' no esta en la colección.");
            //}

            //Comparable maximo = coleccionable.Maximo();
            //int numeroPorTeclado = 45;
            //if (maximo is Persona)
            //{ 
            //    maximo = new Persona("", numeroPorTeclado);
            //    if (coleccionable.Contiene(maximo))
            //        Console.WriteLine("Contiene la personas con dni {45}");
            //}
        }

        public static void ImprimirElementos(IColeccionable coleccionable)
        {
            Iterador iter = new IteradorDePila(coleccionable);

            while (!iter.fin())
            {
                Console.WriteLine(iter.actual());
                iter.siguiente();
            }
        }

        public static void CambiarEstrategia(IColeccionable coleccionable, IStrategyComparable strategyComparable)
        {
            Pila pilaAlumnos = (Pila)coleccionable;

            foreach (var item in pilaAlumnos.pila)
            {
                Alumno alumno = (Alumno)item;
                alumno.strategyComparable = strategyComparable;
            }
        }

        public static void Llenar(IColeccionable coleccionable, int opcion)
        {
            for (int i = 0; i < 20; i++)
            {
                IComparable comparable = Fabrica.crearAleatorio(opcion);
                coleccionable.Agregar(comparable);
            }
        }

        public static void Informar(IColeccionable coleccionable, int opcion)
        {
            Console.WriteLine("El más grande de la coleccion es {0} ", coleccionable.Maximo());
            Console.WriteLine("El más chico de la coleccion es {0} ", coleccionable.Minimo());
            Console.WriteLine("La cantidad de elementos de la cola es {0}", coleccionable.Cuantos());

            IComparable comparable = Fabrica.crearPorTeclado(opcion);
            if (coleccionable.Contiene(comparable))
            {
                Console.WriteLine("El elemento leido está en la colección.");
            }
            else
            {
                Console.WriteLine("El elemento leido no está en la colección.");
            }
        }
    }
}
