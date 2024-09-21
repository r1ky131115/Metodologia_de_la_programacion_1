using Metodologías_de_Programación_I.Helpers;
using Metodologías_de_Programación_I.Interfaces;
using IComparable = Metodologías_de_Programación_I.Interfaces.IComparable;

namespace Metodologías_de_Programación_I.Clases.Factory
{
    public abstract class Fabrica
    {
        public static IComparable crearAleatorio(int opcion)
        {
            Fabrica creator = null;

            opcion = GeneradorDeDatosAleatorios.numeroAleatorio(2);

            switch (opcion)
            {
                case 0:
                    creator = new FabricaDeAlumno();
                    break;
                case 1:
                    creator = new FabricaDeNumero();
                    break;
                default:
                    creator = new FabricaDeNumero();
                    break;
            }

            return creator.FactoryMethod();
        }

        public static IComparable crearPorTeclado(int opcion)
        {
            Fabrica creator = null;

            switch (opcion)
            {
                case 0:
                    creator = new FabricaDeAlumno();
                    break;
                case 1:
                    creator = new FabricaDeNumero();
                    break;
                default:
                    creator = new FabricaDeNumero();
                    break;
            }

            return creator.FactoryMethod();
        }

        public abstract IComparable FactoryMethod();
    }
}
