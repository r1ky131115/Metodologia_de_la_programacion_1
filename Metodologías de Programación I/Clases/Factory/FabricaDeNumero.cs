namespace Metodologías_de_Programación_I.Clases.Factory
{
    public class FabricaDeNumero : Fabrica
    {
        public override Interfaces.IComparable FactoryMethod()
        {
            return new Numero(new Random().Next());
        }
    }
}
