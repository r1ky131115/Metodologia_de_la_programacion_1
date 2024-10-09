using Metodologías_de_Programación_I.Interfaces;

namespace Metodologías_de_Programación_I.Clases.Proxy
{
    public class ProxyAlumnoMuyEstudioso : Alumno
    {
        AlumnoMuyEstudioso AlumnoMuyEstudioso = null;

        public ProxyAlumnoMuyEstudioso(string n, int d, int l, double p, IStrategyComparable strategy) : base(n, d, l, p, strategy)
        {
        }

        public override int ResponderPregunta(int pregunta)
        {
            if (AlumnoMuyEstudioso == null) 
            {
                Console.WriteLine("Creando a traves del ProxyAlumnoMuyEstudioso el AlumnoMuyEstudioso...");
                AlumnoMuyEstudioso = Helper.CrearAlumnoMuyEstudiosoAleatorio();

                return AlumnoMuyEstudioso.AnswerQuestion(pregunta);
            }

            return 0;
        }
    }
}
