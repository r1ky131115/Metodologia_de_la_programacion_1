using Metodologías_de_Programación_I.Clases.Iteradores;
using Metodologías_de_Programación_I.Interfaces;
using IComparable = Metodologías_de_Programación_I.Interfaces.IComparable;

namespace Metodologías_de_Programación_I.Clases
{
    public class Conjunto : IColeccionable, Iterable
    {
        List<IComparable> listaConjunto = new List<IComparable>();
        public Diccionario Diccionario { get; set; }
        int paginaActual;

        public Conjunto()
        {
            Diccionario = new Diccionario();
        }

        public void Agregar(IComparable elemento)
        {
            Diccionario.Agregar(elemento);

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
    }
}
