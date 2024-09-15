using Metodologías_de_Programación_I.Clases.Iteradores;
using Metodologías_de_Programación_I.Interfaces;
using IComparable = Metodologías_de_Programación_I.Interfaces.IComparable;

namespace Metodologías_de_Programación_I.Clases
{
    public class Pila : IColeccionable, Iterable
    {
        public List<IComparable> pila {  get; set; }

        public Pila()
        {
            pila = new List<IComparable>();
        }

        public void Agregar(IComparable comparable)
        {
            pila.Add(comparable);
        }

        public bool Contiene(IComparable comparable)
        {
            foreach(var i in pila)
            {
                if (i.sosIgual(comparable))
                {
                    return true;
                }
            }
            return false;
        }

        public int Cuantos()
        {
            return pila.Count;
        }

        public IComparable Maximo()
        {
            if (pila.Count == 0) throw new InvalidOperationException("La pila está vacía.");
            IComparable max = pila[0];
            foreach (var i in pila)
            {
                if (max == null)
                {
                    max = i;
                }
                else
                {
                    if (!max.sosMayor(i))
                    {
                        max = i;
                    }
                }
            }
            return max;
        }

        public IComparable Minimo()
        {
            if (pila.Count == 0) throw new InvalidOperationException("La pila está vacía.");
            IComparable min = pila[0];
            foreach (var i in pila)
            {
                if (min == null)
                {
                    min = i;
                }
                else
                {
                    if (!min.sosMenor(i))
                    {
                        min = i;
                    }
                }
            }
            return min;
        }

        public Iterador CrearIterador()
        {
            return new IteradorDePila(this);
        }
    }
}
