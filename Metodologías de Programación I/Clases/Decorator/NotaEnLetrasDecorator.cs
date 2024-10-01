using Metodologías_de_Programación_I.Interfaces;

namespace Metodologías_de_Programación_I.Clases.Decorator
{
    public class NotaEnLetrasDecorator : StudentDecorator
    {
        public NotaEnLetrasDecorator(IStudent student) : base(student) { }

        public override string MostrarCalificacion()
        {
            string[] numerosEnLetras = { "UNO", "DOS", "TRES", "CUATRO", "CINCO", "SEIS", "SIETE", "OCHO", "NUEVE", "DIEZ" };
            int nota = student.GetCalification();
            return $"{base.MostrarCalificacion()} ({numerosEnLetras[nota - 1]})";
        }
    }

}
