using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodologías_de_Programación_I.Clases
{
    public class AlumnoMuyEstudioso : Alumno
    {
        public AlumnoMuyEstudioso(string nombre, int dni, int legajo, double promedio)
            : base(nombre, dni, legajo, promedio)
        {
        }

        public override int ResponderPregunta(int pregunta)
        {
            return pregunta % 3; 
        }
    }
}
