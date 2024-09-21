namespace Metodologías_de_Programación_I.Interfaces
{
    public interface IFabricaDeComparables
    {
        IComparable crearAleatorio(int opcion);
        IComparable crearPorTeclado(int opcion);
    }
}
