using Metodologías_de_Programación_I.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IComparable = Metodologías_de_Programación_I.Interfaces.IComparable;

namespace Metodologías_de_Programación_I.Clases
{
    public partial class CompararPorNombre : IStrategyComparable
    {
        public bool SosMayor(IComparable a, IComparable b) => string.Compare(((Alumno)a).getNombre(), ((Alumno)b).getNombre()) > 0;
        public bool SosMenor(IComparable a, IComparable b) => string.Compare(((Alumno)a).getNombre(), ((Alumno)b).getNombre()) < 0;
        public bool SosIgual(IComparable a, IComparable b) => string.Compare(((Alumno)a).getNombre(), ((Alumno)b).getNombre()) == 0;
    }

    public partial class CompararPorPromedio : IStrategyComparable
    {
        public bool SosMayor(IComparable a, IComparable b) => ((Alumno)a).getPromedio() > ((Alumno)b).getPromedio();
        public bool SosMenor(IComparable a, IComparable b) => ((Alumno)a).getPromedio() < ((Alumno)b).getPromedio();
        public bool SosIgual(IComparable a, IComparable b) => ((Alumno)a).getPromedio() == ((Alumno)b).getPromedio();
    }

    public partial class CompararPorDNI : IStrategyComparable
    {
        public bool SosMayor(IComparable a, IComparable b) => ((Alumno)a).getDni() > ((Alumno)b).getDni();
        public bool SosMenor(IComparable a, IComparable b) => ((Alumno)a).getDni() < ((Alumno)b).getDni();
        public bool SosIgual(IComparable a, IComparable b) => ((Alumno)a).getDni() == ((Alumno)b).getDni();
    }

    public partial class CompararPorLegajo : IStrategyComparable
    {
        public bool SosMayor(IComparable a, IComparable b) => ((Alumno)a).getLegajo() > ((Alumno)b).getLegajo();
        public bool SosMenor(IComparable a, IComparable b) => ((Alumno)a).getLegajo() < ((Alumno)b).getLegajo();
        public bool SosIgual(IComparable a, IComparable b) => ((Alumno)a).getLegajo() == ((Alumno)b).getLegajo();
    }
}
