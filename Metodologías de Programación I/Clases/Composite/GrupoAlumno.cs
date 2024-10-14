using Metodologías_de_Programación_I.Interfaces.Composite;

namespace Metodologías_de_Programación_I.Clases.Composite
{
    public class GrupoAlumno : IAlumnoComponent
    {
        private List<IAlumnoComponent> alumnos;

        public GrupoAlumno()
        {
            alumnos = new List<IAlumnoComponent>();
        }

        public void AgregarAlumno(IAlumnoComponent alumno)
        {
            alumnos.Add(alumno);
        }

        public void RemoverAlumno(IAlumnoComponent alumno)
        {
            alumnos.Remove(alumno);
        }

        public string getNombre()
        {
            return string.Join(", ", alumnos.Select(a => a.getNombre()));
        }

        public string responderPregunta()
        {
            Dictionary<string, int> respuestaVotos = new Dictionary<string, int>();

            foreach (var alumno in alumnos)
            {
                string respuesta = alumno.responderPregunta();
                if (!string.IsNullOrEmpty(respuesta))
                {
                    if (respuestaVotos.ContainsKey(respuesta))
                    {
                        respuestaVotos[respuesta]++;
                    }
                    else
                    {
                        respuestaVotos[respuesta] = 1;
                    }
                }
            }

            if (respuestaVotos.Count == 0) return null;

            int maxVotos = respuestaVotos.Values.Max();
            var respuestasMaximas = respuestaVotos.Where(r => r.Value == maxVotos).Select(r => r.Key).ToList();

            Random rnd = new Random();
            return respuestasMaximas[rnd.Next(respuestasMaximas.Count)];
        }

        public void setCalificacion(int calificacion)
        {
            foreach (var alumno in alumnos)
            {
                alumno.setCalificacion(calificacion);
            }
        }

        public void mostrarCalificacion()
        {
            foreach (var alumno in alumnos)
            {
                alumno.mostrarCalificacion();
            }
        }

        public bool sosIgual(IAlumnoComponent alumno)
        {
            return alumnos.Any(a => a.sosIgual(alumno));
        }

        public bool sosMenor(IAlumnoComponent alumno)
        {
            return alumnos.All(a => a.sosMenor(alumno));
        }

        public bool sosMayor(IAlumnoComponent alumno)
        {
            return alumnos.All(a => a.sosMayor(alumno));
        }
    }
}
