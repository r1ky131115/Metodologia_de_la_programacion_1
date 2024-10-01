using Metodologías_de_Programación_I.Interfaces;

namespace Metodologías_de_Programación_I.Clases.Decorator
{
    public class EstadoDecorator : StudentDecorator
    {
        public EstadoDecorator(IStudent student) : base(student) { }

        public override string MostrarCalificacion()
        {
            int nota = student.GetCalification();
            string estado = nota >= 7 ? "PROMOCIÓN" : (nota >= 4 ? "APROBADO" : "DESAPROBADO");
            return $"{base.MostrarCalificacion()} ({estado})";
        }
    }

}
