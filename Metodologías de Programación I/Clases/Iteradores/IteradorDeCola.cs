using Metodologías_de_Programación_I.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodologías_de_Programación_I.Clases.Iteradores
{
    public class IteradorDeCola : Iterador
    {
        int elementoActual;
        Cola cIteable;

        public IteradorDeCola(IColeccionable c)
        {
            cIteable = (Cola)c;
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
            return elementoActual >= cIteable.cola.Count;
        }

        public object actual()
        {
            return cIteable.cola[elementoActual];
        }
    }
}
