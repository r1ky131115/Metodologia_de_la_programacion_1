using System.Text;

namespace Metodologías_de_Programación_I.Helpers
{
    public class GeneradorDeDatosAleatorios
    {
        public static int numeroAleatorio(int max)
        {
            if (max <= 0) throw new ArgumentOutOfRangeException(nameof(max), "El valor debe ser mayor que 0.");
            return new Random().Next(0, max);
        }

        public static string StringAleatorio(int cant)
        {
            if (cant <= 0) throw new ArgumentOutOfRangeException(nameof(cant), "El valor debe ser mayor que 0.");
            const string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()_+-=<>?";
            StringBuilder resultado = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < cant; i++)
            {
                int index = random.Next(caracteres.Length);
                resultado.Append(caracteres[index]);
            }

            return resultado.ToString();
        }
    }
}
