using Metodologias_de_Programacion_I_2024.Interfaces;
using Metodologias_de_Programacion_I_2024.Interfaces.Strategy;

namespace Metodologias_de_Programacion_I_2024.Clases.Strategy
{
    public partial class CompararPorNombre : IStrategyAlumno
    {
        public bool SosMayor(Comparable a, Comparable b) => string.Compare(((Alumno)a).getNombre(), ((Alumno)b).getNombre()) > 0;
        public bool SosMenor(Comparable a, Comparable b) => string.Compare(((Alumno)a).getNombre(), ((Alumno)b).getNombre()) < 0;
        public bool SosIgual(Comparable a, Comparable b) => string.Compare(((Alumno)a).getNombre(), ((Alumno)b).getNombre()) == 0;
    }
}
