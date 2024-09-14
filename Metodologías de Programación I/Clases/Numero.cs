using IComparable = Metodologías_de_Programación_I.Interfaces.IComparable;

namespace Metodologías_de_Programación_I.Clases
{
    public class Numero : IComparable
    {
        public int valor;

        public Numero(int v)
        {
            this.valor = v;
        }

        public int getValor()
        {
            return valor;
        }

        public bool sosIgual(IComparable comparable)
        {
            Numero otroNumero = (Numero)comparable;
            return this.valor == otroNumero.getValor();
        }

        public bool sosMenor(IComparable comparable)
        {
            Numero otroNumero = (Numero)comparable;
            return this.valor < otroNumero.getValor();
        }

        public bool sosMayor(IComparable comparable)
        {
            Numero otroNumero = (Numero)comparable;
            return this.valor > otroNumero.getValor();
        }

        public override string ToString() 
        {
            return this.getValor().ToString();
        }
    }
}
