using Metodologías_de_Programación_I.Helpers;

namespace Metodologías_de_Programación_I.Clases.Factory
{
    public class FabricaDeAlumno : Fabrica
    {
        public override Interfaces.IComparable FactoryMethod()
        {
            Random random = new Random();
            string nombreAleatorio = GeneradorDeDatosAleatorios.StringAleatorio(4);
            int dniAleatorio = random.Next(10000000, 99999999);
            int legajoAleatorio = random.Next(1000, 9999);
            double promedioAleatorio = Math.Round(random.NextDouble() * 10, 2);

            return new Alumno(nombreAleatorio, dniAleatorio, legajoAleatorio, promedioAleatorio, null);
        }
    }
}
