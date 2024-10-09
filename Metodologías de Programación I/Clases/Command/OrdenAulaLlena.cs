using Metodologías_de_Programación_I.Interfaces.Command;

namespace Metodologías_de_Programación_I.Clases.Command
{
    public class OrdenAulaLlena : IOrdenEnAula1
    {
        private Aula _aula;

        public OrdenAulaLlena(Aula aula)
        {
            _aula = aula;
        }

        public void Ejecutar()
        {
            _aula.ClaseLista();
        }
    }
}
