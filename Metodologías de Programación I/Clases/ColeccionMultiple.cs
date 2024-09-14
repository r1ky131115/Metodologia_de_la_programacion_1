using Metodologías_de_Programación_I.Interfaces;
using IComparable = Metodologías_de_Programación_I.Interfaces.IComparable;

namespace Metodologías_de_Programación_I.Clases
{
    public class ColeccionMultiple: IColeccionable
    {
        public Pila Pila { get; set; }
        public Cola Cola { get; set; }

        public ColeccionMultiple(Pila p, Cola c)
        {
            this.Pila = p;
            this.Cola = c;
        }

        public int Cuantos()
        {
            return Pila.Cuantos() + Cola.Cuantos();
        }

        public IComparable Minimo()
        {
            IComparable minPila = Pila.Minimo();
            IComparable minCola = Cola.Minimo();

            IComparable minGeneral = null;

            if (minPila != null && minCola != null)
            {
                if (minPila.sosMenor(minCola))
                {
                    minGeneral = minPila;
                }
                else
                {
                    minGeneral = minCola;
                }
            }

            return minGeneral;
        }

        public IComparable Maximo()
        {
            IComparable minPila = Pila.Minimo();
            IComparable minCola = Cola.Minimo();

            IComparable maxGeneral = null;

            if (minPila != null && minCola != null)
            {
                if (minPila.sosMenor(minCola))
                {
                    maxGeneral = minPila;
                }
                else
                {
                    maxGeneral = minCola;
                }
            }

            return maxGeneral;
        }

        public void Agregar(Interfaces.IComparable comparable)
        {
            throw new NotImplementedException();
        }

        public bool Contiene(Interfaces.IComparable comparable)
        {
            return Pila.Contiene(comparable) || Cola.Contiene(comparable);
        }
    }
}
