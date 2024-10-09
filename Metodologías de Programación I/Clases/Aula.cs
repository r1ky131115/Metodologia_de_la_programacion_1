using Metodologías_de_Programación_I.Clases.Adapter;

namespace Metodologías_de_Programación_I.Clases
{
    public class Aula
    {
        Teacher teacher = null;
        public void Comenzar()
        {
            Console.WriteLine("Comenzando la clase...");

            if (teacher == null)
            {
                teacher = new Teacher();
            }
        }

        public void nuevoAlumno(Alumno alumno)
        {
            if (teacher != null)
            {
                teacher.GoToClass(alumno);
            }
        }

        public void ClaseLista()
        {
            if (teacher != null)
            {
                teacher.TeachingAClass();
            }
            else
            {
                Console.WriteLine("No hay maestro asignado. Comience la clase primero.");
            }
        }
    }
}
