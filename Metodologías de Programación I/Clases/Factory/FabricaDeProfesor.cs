using Metodologías_de_Programación_I.Helpers;

namespace Metodologías_de_Programación_I.Clases.Factory
{
    internal class FabricaDeProfesor : Fabrica
    {
        public override Interfaces.IComparable FactoryMethod()
        {
            Random random = new Random();
            string nombreAleatorio = GeneradorDeDatosAleatorios.StringAleatorio(4);
            int dniAleatorio = random.Next(10000000, 99999999);
            int antiguedad = random.Next(0, 50);

            return new Profesor(nombreAleatorio, dniAleatorio, antiguedad);
        }
    }
}
