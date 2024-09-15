namespace Metodologías_de_Programación_I.Interfaces
{
    public interface IStrategyComparable
    {
        bool SosMayor(IComparable a, IComparable b);
        bool SosMenor(IComparable a, IComparable b);
        bool SosIgual(IComparable a, IComparable b);
    }
}
