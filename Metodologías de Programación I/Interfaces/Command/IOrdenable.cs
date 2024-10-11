using System;

namespace Metodologías_de_Programación_I.Interfaces.Command
{
    internal interface IOrdenable
    {
        void setOrdenInicio(IOrdenEnAula1 ordenEnAula1);
        void setOrdenLlegaAlumno(IOrdenEnAula2 ordenEnAula2, IComparable comparable);
        void setOrdenAulaLlena(IOrdenEnAula1 ordenEnAula1);
    }
}
