using Metodologías_de_Programación_I.Interfaces;

namespace Metodologías_de_Programación_I.Clases.Decorator
{
    public class RecuadroDecorator : StudentDecorator
    {
        public RecuadroDecorator(IStudent student) : base(student) { }

        public override string MostrarCalificacion()
        {
            string resultado = base.MostrarCalificacion();
            string recuadro = new string('*', resultado.Length + 4);
            return $"{recuadro}\n* {resultado} *\n{recuadro}";
        }
    }

}
