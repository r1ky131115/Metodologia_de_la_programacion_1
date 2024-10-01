using Metodologías_de_Programación_I.Interfaces;

namespace Metodologías_de_Programación_I.Clases.Decorator
{
    public class LegajoDecorator : StudentDecorator
    {
        private int legajo;

        public LegajoDecorator(IStudent student, int legajo) : base(student)
        {
            this.legajo = legajo;
        }

        public override string MostrarCalificacion()
        {
            return $"{base.MostrarCalificacion()} ({legajo})";
        }
    }

}
