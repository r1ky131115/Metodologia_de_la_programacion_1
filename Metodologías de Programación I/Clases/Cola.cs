using Metodologías_de_Programación_I.Interfaces;
using IComparable = Metodologías_de_Programación_I.Interfaces.IComparable;
using System;
using System.Collections.Generic;


namespace Metodologías_de_Programación_I.Clases
{
    public class Cola : IColeccionable
    {
        public List<IComparable> cola = new List<IComparable>();

        public void Agregar(IComparable comparable)
        {
            cola.Add(comparable);
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
                    if (max.sosMayor(i))
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
                    if (min.sosMenor(i))
                    {
                        min = i;
                    }
                }
            }
            return min;
        }
    }
}
