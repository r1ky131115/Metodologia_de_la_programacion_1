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
    }
}
