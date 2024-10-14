using Metodologías_de_Programación_I.Interfaces.Composite;

namespace Metodologías_de_Programación_I.Clases.Composite
{
    public class AlumnoComponent : IAlumnoComponent
    {
        private string nombre;
        private string apellido;
        private int calificacion;
        private Dictionary<string, int> respuestasVotadas;

        public AlumnoComponent(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.respuestasVotadas = new Dictionary<string, int>();
        }

        public string getNombre()
        {
            return $"{nombre} {apellido}";
        }

        public string responderPregunta()
        {
            if (respuestasVotadas.Count == 0) return null;

            // Devuelve la respuesta con más votos (en caso de empate, elige una al azar)
            int maxVotos = respuestasVotadas.Values.Max();
            var respuestasMaximas = respuestasVotadas.Where(r => r.Value == maxVotos).Select(r => r.Key).ToList();

            Random rnd = new Random();
            return respuestasMaximas[rnd.Next(respuestasMaximas.Count)];
        }

        public void votarRespuesta(string respuesta)
        {
            if (respuestasVotadas.ContainsKey(respuesta))
            {
                respuestasVotadas[respuesta]++;
            }
            else
            {
                respuestasVotadas[respuesta] = 1;
            }
        }

        public void setCalificacion(int calificacion)
        {
            this.calificacion = calificacion;
        }

        public void mostrarCalificacion()
        {
            Console.WriteLine($"{getNombre()} tiene una calificación de {calificacion}");
        }

        public bool sosIgual(IAlumnoComponent alumno)
        {
            return this.getNombre() == alumno.getNombre();
        }

        public bool sosMenor(IAlumnoComponent alumno)
        {
            return string.Compare(this.getNombre(), alumno.getNombre()) < 0;
        }

        public bool sosMayor(IAlumnoComponent alumno)
        {
            return string.Compare(this.getNombre(), alumno.getNombre()) > 0;
        }
    }
}
