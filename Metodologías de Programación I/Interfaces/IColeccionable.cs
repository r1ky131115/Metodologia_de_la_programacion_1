namespace Metodologías_de_Programación_I.Interfaces
{
    public interface IColeccionable
    {
        int Cuantos();
        IComparable Minimo();
        IComparable Maximo();
        void Agregar(IComparable comparable);
        bool Contiene(IComparable comparable);
    }
}
