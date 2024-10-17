using Metodologias_de_Programacion_I_2024.Colecciones;

namespace Metodologias_de_Programacion_I_2024
{
    public static class Menu
    {
        public static void Practica_1()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Ejercicio del 1 al 10");
            Console.ResetColor();

            Pila pila = new Pila();
            Cola cola = new Cola();
            ColeccionMultiple coleccionMultiple = new ColeccionMultiple(pila, cola);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Llenando la pila...");
            Console.ResetColor();
            Helper.Llenar(pila);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Pila llena.");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Llenando la cola...");
            Console.ResetColor();
            Helper.Llenar(cola);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Cola llena.");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Informando sobre la pila...");
            Console.ResetColor();
            Helper.Informar(pila);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Información de la pila mostrada.");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Informando sobre la cola...");
            Console.ResetColor();
            Helper.Informar(cola);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Información de la cola mostrada.");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Informando sobre la colección múltiple...");
            Console.ResetColor();
            Helper.Informar(coleccionMultiple);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Información de la colección múltiple mostrada.");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("******************************************************");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Para reflexionar. Además de la creación de la nueva clase ColeccionMultiple y la adaptación del módulo main, responda ¿qué tuvo que modificar de lo realizado en los primeros seis ejercicios?");
            Console.ResetColor();
            Console.WriteLine("Reflexión: " +
                "No se tuvo que modificar nada ya que las colecciones trabajan con objetos comparables, lo que permite una flexibilidad en la implementación de las mismas.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("******************************************************");




            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Ejercicio del 11 al 15");
            Console.ResetColor();

            Pila pilaPersonas = new Pila();
            Cola colaPersonas = new Cola();
            ColeccionMultiple coleccionMultiplePersonas = new ColeccionMultiple(pilaPersonas, colaPersonas);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Llenando personas en la pila...");
            Console.ResetColor();
            Helper.LlenarPersonas(pilaPersonas);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Personas en la pila llenadas.");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Llenando personas en la cola...");
            Console.ResetColor();
            Helper.LlenarPersonas(colaPersonas);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Personas en la cola llenadas.");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Informando sobre la Coleccion Multiple Personas nuevamente...");
            Console.ResetColor();
            Helper.Informar(coleccionMultiplePersonas);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Información de la Coleccion Multiple Personas mostrada nuevamente.");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("******************************************************");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Para reflexionar. Además de la creación de la nueva clase Persona, la creación de la función llenarPersonas y la adaptación del módulo main, responda ¿qué tuvo que modificar de lo realizado en los ejercicios 1 a 6 y el 8?");
            Console.ResetColor();
            Console.WriteLine("Reflexión: " +
                "No se tuvo que modificar nada ya que las colecciones trabajan con objetos comparables, solo especificar en las comparaciones que el comparable es del tipo Persona, lo que permite una flexibilidad en la implementación de las mismas.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("******************************************************");


            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Ejercicio del 16 al 19");
            Console.ResetColor();

            Pila pilaAlumnos = new Pila();
            Cola colaAlumnos = new Cola();
            ColeccionMultiple coleccionMultipleAlumnos = new ColeccionMultiple(pilaAlumnos, colaAlumnos);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Llenando personas en la pila...");
            Console.ResetColor();
            Helper.LlenarPersonas(pilaAlumnos);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Personas en la pila llenadas.");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Llenando personas en la cola...");
            Console.ResetColor();
            Helper.LlenarPersonas(colaAlumnos);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Personas en la cola llenadas.");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Informando sobre la Coleccion Multiple Alumnos nuevamente...");
            Console.ResetColor();
            Helper.Informar(coleccionMultipleAlumnos);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Información de la Coleccion Multiple Alumnos mostrada nuevamente.");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("******************************************************");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Responda ¿Funcionó? ¿Fue necesario decir explícitamente que Alumno tiene que implementar la interface Comparable? ¿Cuál fue el criterio por el cual se comparó a los alumnos? ¿Por qué?");
            Console.ResetColor();
            Console.WriteLine("Respuesta: " +
                "Funciono. No fue necesario explicitamente decir que alumno tenga que implementar la interface comparable ya que la heredo de persona. Se los comparo por legajo.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("******************************************************");

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("******************************************************");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Para reflexionar. Responda ¿Podría haber hecho esto mismo sin interfaces? ¿A qué costo?");
            Console.ResetColor();
            Console.WriteLine("Reflexión: " +
                "Sí, podría haber hecho lo mismo sin interfaces, pero a un costo significativo. Sin interfaces, habría perdido la flexibilidad y el polimorfismo, obligándo a duplicar código para cada tipo de colección (Pila, Cola, etc.) y para cada tipo de objeto (Persona, Alumno). Esto resultaría en un diseño rígido, difícil de mantener y extender, ya que cada cambio requeriría modificar múltiples partes del código en lugar de simplemente implementar una nueva interfaz o clase que siga un contrato común. Además, el código sería menos reutilizable y menos claro.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("******************************************************");

        }

        public static void Practica_2()
        {

        }
    }
}
