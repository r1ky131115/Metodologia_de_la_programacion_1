using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metodologías_de_Programación_I.Interfaces;

namespace Metodologías_de_Programación_I.Clases
{
    public class CompararPorNombre : IStrategyComparable
    {
        public bool SosMayor(Alumno a, Alumno b) => string.Compare(a.getNombre(), b.getNombre()) > 0;
        public bool SosMenor(Alumno a, Alumno b) => string.Compare(a.getNombre(), b.getNombre()) < 0;
        public bool SosIgual(Alumno a, Alumno b) => string.Compare(a.getNombre(), b.getNombre()) == 0;
    }
}
