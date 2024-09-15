using Metodologías_de_Programación_I.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodologías_de_Programación_I.Clases.Iteradores
{
    public class IteradorDePila : Iterador
    {
        Pila pIterable;
        int elementoActual;

        public IteradorDePila(IColeccionable p)
        {
            pIterable = (Pila)p;
            primero();
        }

        public void primero()
        {
            elementoActual = 0;
        }

        public void siguiente()
        {
            elementoActual++;
        }

        public bool fin()
        {
            return elementoActual >= pIterable.pila.Count;
        }

        public object actual()
        {
            return pIterable.pila[elementoActual];
        }
    }
}
