using Metodologías_de_Programación_I.Clases.Iteradores;
using Metodologías_de_Programación_I.Interfaces;
using Metodologías_de_Programación_I.Interfaces.Command;
using System;
using IComparable = Metodologías_de_Programación_I.Interfaces.IComparable;

namespace Metodologías_de_Programación_I.Clases
{
    public class Conjunto : IColeccionable, Iterable, IOrdenable
    {
        List<IComparable> listaConjunto = new List<IComparable>();
        public Diccionario Diccionario { get; set; }
        int paginaActual;

        IOrdenEnAula1 ordenInicio;
        IOrdenEnAula1 ordenAulaLlena;
        IOrdenEnAula2 ordenReceptor;

        public Conjunto()
        {
            Diccionario = new Diccionario();
        }

        public void Agregar(IComparable elemento)
        {
            if (Diccionario.Cuantos() == 0)
            {
                setOrdenInicio(ordenInicio);
            }

            setOrdenLlegaAlumno(ordenReceptor, elemento);
            Diccionario.Agregar(elemento);

            if (Diccionario.Cuantos() == 40)
            {
                setOrdenAulaLlena(ordenAulaLlena);
            }

            //if (Contiene(elemento))
            //{
            //    listaConjunto.Add(elemento);
            //}
        }

        public bool Pertenece(IComparable comparable)
        {            
            if (Diccionario.Contiene(comparable))
            {
                return true;
            }
            return false;

            //if (!Contiene(elemento))
            //{
            //    return true;
            //}
            //return false;
        }

        public bool Contiene(IComparable comparable)
        {
            if (Diccionario.Contiene(comparable))
            {
                return true;
            }
            return false;

            //if (listaConjunto.Count == 0) throw new InvalidOperationException("El conjunto está vacía.");
            //foreach (var item in listaConjunto)
            //{
            //    if (item.sosIgual(comparable))
            //    {
            //        return false;
            //    }
            //}
            //return true;
        }

        public int Cuantos()
        {
            return listaConjunto.Count();
        }

        public IComparable Maximo()
        {
            return Diccionario.Maximo();
            //if (listaConjunto.Count == 0) throw new InvalidOperationException("El conjunto está vacía.");
            //IComparable min = listaConjunto[0];
            //foreach (var i in listaConjunto)
            //{
            //    if (min == null)
            //    {
            //        min = i;
            //    }
            //    else
            //    {
            //        if (!min.sosMayor(i))
            //        {
            //            min = i;
            //        }
            //    }
            //}
            //return min;
        }

        public IComparable Minimo()
        {
            return Diccionario.Minimo();
            //if (listaConjunto.Count == 0) throw new InvalidOperationException("El conjunto está vacía.");
            //IComparable min = listaConjunto[0];
            //foreach (var i in listaConjunto)
            //{
            //    if (min == null)
            //    {
            //        min = i;
            //    }
            //    else
            //    {
            //        if (!min.sosMenor(i))
            //        {
            //            min = i;
            //        }
            //    }
            //}
            //return min;
        }

        public Iterador CrearIterador()
        {
            return new IteradorDeConjunto(this);
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
