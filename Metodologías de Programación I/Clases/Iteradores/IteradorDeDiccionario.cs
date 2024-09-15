using Metodologías_de_Programación_I.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodologías_de_Programación_I.Clases.Iteradores
{
    public class IteradorDeDiccionario : Iterador
    {
        int elementoActual;

        Diccionario dIterable;

        public IteradorDeDiccionario(IColeccionable d)
        {
            dIterable = (Diccionario)d;
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
            return elementoActual >= dIterable.elementos.Count;
        }

        public object actual()
        {
            return dIterable.elementos[elementoActual];
        }
    }
}
