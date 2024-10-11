using Metodologías_de_Programación_I.Clases.Iteradores;
using Metodologías_de_Programación_I.Interfaces;
using Metodologías_de_Programación_I.Interfaces.Command;
using IComparable = Metodologías_de_Programación_I.Interfaces.IComparable;

namespace Metodologías_de_Programación_I.Clases
{
    public class Pila : IColeccionable, Iterable, IOrdenable
    {
        public List<IComparable> pila {  get; set; }

        IOrdenEnAula1 ordenInicio;
        IOrdenEnAula1 ordenAulaLlena;
        IOrdenEnAula2 ordenReceptor;

        public Pila()
        {
            pila = new List<IComparable>();
        }

        public void Agregar(IComparable comparable)
        {
            if (pila.Count == 0)
            {
                setOrdenInicio(ordenInicio);
            }

            setOrdenLlegaAlumno(ordenReceptor, comparable);
            pila.Add(comparable);

            if (pila.Count == 40)
            {
                setOrdenAulaLlena(ordenAulaLlena);
            }
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

        public void setOrdenInicio(IOrdenEnAula1 ordenEnAula1)
        {
            ordenInicio = ordenEnAula1;
            ordenInicio?.Ejecutar();
        }

        public void setOrdenLlegaAlumno(IOrdenEnAula2 ordenEnAula2, IComparable comparable)
        {
            ordenReceptor = ordenEnAula2;
            ordenReceptor?.Ejecutar(comparable);
        }

        public void setOrdenAulaLlena(IOrdenEnAula1 ordenEnAula1)
        {
            ordenAulaLlena = ordenEnAula1;
            ordenAulaLlena?.Ejecutar();
        }
    }
}
