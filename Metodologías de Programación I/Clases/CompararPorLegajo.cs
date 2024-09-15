using Metodologías_de_Programación_I.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodologías_de_Programación_I.Clases
{
    public class CompararPorLegajo : IStrategyComparable
    {
        public bool SosMayor(Alumno a, Alumno b) => a.getLegajo() > b.getLegajo();
        public bool SosMenor(Alumno a, Alumno b) => a.getLegajo() < b.getLegajo();
        public bool SosIgual(Alumno a, Alumno b) => a.getLegajo() == b.getLegajo();
    }
}
