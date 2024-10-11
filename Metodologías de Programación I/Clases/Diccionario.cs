using Metodologías_de_Programación_I.Clases.Iteradores;
using Metodologías_de_Programación_I.Interfaces;
using Metodologías_de_Programación_I.Interfaces.Command;
using System;
using IComparable = Metodologías_de_Programación_I.Interfaces.IComparable;

namespace Metodologías_de_Programación_I.Clases
{
    public class Diccionario : IColeccionable, Iterable, IOrdenable
    {
        public List<ClaveValor> elementos;

        public Diccionario()
        {
            elementos = new List<ClaveValor>();
        }

        IOrdenEnAula1 ordenInicio;
        IOrdenEnAula1 ordenAulaLlena;
        IOrdenEnAula2 ordenReceptor;

        public void agregar(IComparable clave, object valor)
        {
            ClaveValor existente = elementos.Find(cv => cv.Clave.sosIgual(clave));

            if (existente != null)
            {
                existente.Valor = valor;
            }
            else
            {
                ClaveValor cl = new ClaveValor(clave, valor);
                elementos.Add(cl);

                if (elementos.Count == 0)
                {
                    setOrdenInicio(ordenInicio);
                }

                setOrdenLlegaAlumno(ordenReceptor, (IComparable)cl);
                elementos.Add(new ClaveValor(clave, valor));

                if (elementos.Count == 40)
                {
                    setOrdenAulaLlena(ordenAulaLlena);
                }
            }
        }

        public object valorDe(IComparable clave)
        {
            ClaveValor existente = elementos.Find(cv => cv.Clave.sosIgual(clave));
            return existente != null ? existente.Valor : null;
        }

        public void Agregar(IComparable comparable)
        {
            agregar(comparable, -1);
        }

        public bool Contiene(IComparable comparable)
        {
            if (elementos.Count == 0) throw new InvalidOperationException("El diccioario está vacío.");

            for (int i = 0; i <= elementos.Count ;i++)
            {
                if (comparable.sosIgual(elementos[i].Clave))
                {
                    return true;
                }
            }

            return false;
        }

        public int Cuantos()
        {
            return elementos.Count;
        }

        public IComparable Maximo()
        {
            if (elementos.Count == 0) throw new InvalidOperationException("El diccioario está vacío.");
            IComparable maximo = (IComparable)elementos[0].Valor;

            foreach (IComparable comparable in elementos)
            {
                if (!comparable.sosMayor(maximo))
                {
                    maximo = comparable;
                }
            }
            return maximo;
        }

        public IComparable Minimo()
        {
            if (elementos.Count == 0) throw new InvalidOperationException("El diccioario está vacío.");
            IComparable minimo = (IComparable)elementos[0].Valor;

            foreach (IComparable comparable in elementos)
            {
                if (!comparable.sosMenor(minimo))
                {
                    minimo = comparable;
                }
            }
            return minimo;
        }

        public override string ToString()
        {
            return string.Join(", ", elementos.Select(e => $"{e.Clave}: {e.Valor}"));
        }

        public Iterador CrearIterador()
        {
            return new IteradorDeDiccionario(this);
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


    public class ClaveValor
    {
        public IComparable Clave { get; }
        public object Valor { get; set; }

        public ClaveValor(IComparable clave, object valor)
        {
            this.Clave = clave;
            this.Valor = valor;
        }
    }

}
