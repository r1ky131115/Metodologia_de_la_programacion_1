using Metodologías_de_Programación_I.Interfaces.Observer;

namespace Metodologías_de_Programación_I.Clases
{
    public class Profesor : Persona
    {
        public int antigueada { get; set; }
        
        public Profesor(string n, int d, int antigueada) : base(n, d)
        {
            this.antigueada = antigueada;
        }

        public void hablarALaClase()
        {
            Console.WriteLine("Hablando de algún tema.");
        }

        public void escribirEnElPizarron()
        {
            Console.WriteLine("Escribiendo en el pizarrón.");
        }

        // Lista de alumnos observadores
        private List<IAlumnoObserver> alumnos = new List<IAlumnoObserver>();

        public void AgregarObservador(IAlumnoObserver alumno)
        {
            alumnos.Add(alumno);
        }

        public void QuitarObservador(IAlumnoObserver alumno)
        {
            alumnos.Remove(alumno);
        }

        private void NotificarAtencion()
        {
            foreach (var alumno in alumnos)
            {
                alumno.PrestarAtencion();
            }
        }

        private void NotificarDistraccion()
        {
            foreach (var alumno in alumnos)
            {
                alumno.Distraerse();
            }
        }
    }
}
