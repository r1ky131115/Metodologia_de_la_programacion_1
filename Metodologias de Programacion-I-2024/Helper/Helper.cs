using Metodologias_de_Programacion_I_2024.Clases;
using Metodologias_de_Programacion_I_2024.Colecciones;
using Metodologias_de_Programacion_I_2024.Interfaces;

namespace Metodologias_de_Programacion_I_2024
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

        public static void Llenar(Coleccionable coleccoinable)
        {
            for (int i = 0; i < 20; i++)
            {
                Comparable comparable = new Numero(new Random().Next());
                coleccoinable.Agregar(comparable);
            }
        }

        public static void Informar(Coleccionable coleccionable)
        {
            Console.WriteLine("El más grande de la coleccion es {0} ", coleccionable.Maximo());
            Console.WriteLine("El más chico de la coleccion es {0} ", coleccionable.Minimo());
            Console.WriteLine("La cantidad de elementos de la cola es {0}", coleccionable.Cuantos());

            Comparable comparable = new Numero(new Random().Next());

            if (coleccionable.Contiene(comparable))
            {
                Console.WriteLine($"El elemento '{comparable.ToString()}' esta en la colección.");
            }
            else
            {
                Console.WriteLine($"El elemento '{comparable.ToString()}' no esta en la colección.");
            }

            //Comparable maximo = coleccionable.Maximo();
            //int numeroPorTeclado = 45;
            //if (maximo is Persona)
            //{ 
            //    maximo = new Persona("", numeroPorTeclado);
            //    if (coleccionable.Contiene(maximo))
            //        Console.WriteLine("Contiene la personas con dni {45}");
            //}
        }

        public static void LlenarPersonas(Coleccionable coleccionable)
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

        public static void LlenarAlumnos(Coleccionable coleccionable)
        {
            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                string nombreAleatorio = GetNombre();
                int dniAleatorio = random.Next(10000000, 99999999);
                int legajoAleatorio = random.Next(1000, 9999);
                double promedioAleatorio = Math.Round(random.NextDouble() * 10, 2);

                Alumno alumno = new Alumno(nombreAleatorio, dniAleatorio, legajoAleatorio, promedioAleatorio);
                coleccionable.Agregar(alumno);
            }
        }
    }
}
