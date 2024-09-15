using Metodologías_de_Programación_I.Interfaces;

namespace Metodologías_de_Programación_I.Clases.Iteradores
{
    public class IteradorDeConjunto : Iterador
    {
        int elementoActual;

        Conjunto cjIterable;

        public IteradorDeConjunto(IColeccionable c)
        {
            cjIterable = (Conjunto)c;
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
            return elementoActual >= cjIterable.Diccionario.elementos.Count;
        }

        public object actual()
        {
            return cjIterable.Diccionario.elementos[elementoActual];
        }
    }
}
