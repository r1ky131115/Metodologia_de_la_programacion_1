using Metodologías_de_Programación_I.Clases.Iteradores;
using Metodologías_de_Programación_I.Interfaces;
using Metodologías_de_Programación_I.Interfaces.Command;
using IComparable = Metodologías_de_Programación_I.Interfaces.IComparable;


namespace Metodologías_de_Programación_I.Clases
{
    public class Cola : IColeccionable, Iterable, IOrdenable
    {
        public List<IComparable> cola {  get; set; }
        int paginaActual;

        IOrdenEnAula1 ordenInicio;
        IOrdenEnAula1 ordenAulaLlena;
        IOrdenEnAula2 ordenReceptor;

        public Cola()
        {
            cola = new List<IComparable>();
        }

        public void Agregar(IComparable comparable)
        {
            if (cola.Count == 0)
            {
                setOrdenInicio(ordenInicio);
            }

            setOrdenLlegaAlumno(ordenReceptor, comparable);
            cola.Add(comparable);

            if (cola.Count == 40)
            {
                setOrdenAulaLlena(ordenAulaLlena);
            }
        }

        public bool Contiene(IComparable comparable)
        {
            if (cola.Count == 0) throw new InvalidOperationException("La cola está vacía.");
            foreach (var i in cola)
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
            return cola.Count;
        }

        public IComparable Maximo()
        {
            if (cola.Count == 0) throw new InvalidOperationException("La cola está vacía.");
            IComparable max = cola[0];
            foreach (var i in cola)
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
            if (cola.Count == 0) throw new InvalidOperationException("La cola está vacía.");
            IComparable min = cola[0];
            foreach (var i in cola)
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
            return new IteradorDeCola(this);
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
