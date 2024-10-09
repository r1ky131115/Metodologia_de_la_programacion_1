using Metodologías_de_Programación_I.Interfaces.Command;

namespace Metodologías_de_Programación_I.Clases.Command
{
    public class OrdenReceptor : IOrdenEnAula2
    {
        private Aula _aula;

        public OrdenReceptor(Aula aula)
        {
            _aula = aula;
        }

        public void Ejecutar(Interfaces.IComparable comparable)
        {
            _aula.nuevoAlumno((Alumno)comparable);
        }
    }
}
