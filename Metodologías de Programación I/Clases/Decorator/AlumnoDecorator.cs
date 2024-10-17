using Metodologías_de_Programación_I.Interfaces;
using IComparable = Metodologías_de_Programación_I.Interfaces.IComparable;

namespace Metodologías_de_Programación_I.Clases.Decorator
{
    public abstract class Decorator : IAlumno
    {
        protected IAlumno _al;
        public Decorator(IAlumno al)
        {
            _al = al;
        }

        public int GetCalificacion()
        {
            return _al.GetCalificacion();
        }

        public void Distraerse()
        {
            _al.Distraerse();
        }

        public int GetDni()
        {
            return _al.GetDni();
        }

        public int GetLegajo()
        {
            return _al.GetLegajo();
        }

        public string GetNombre()
        {
            return _al.GetNombre();
        }

        public int GetPromerdio()
        {
            return _al.GetPromerdio();
        }

        public abstract string MostrarCalificacion();


        public void PrestarAtencion()
        {
            _al.PrestarAtencion();
        }

        public int ResponderPregunta(int pregunta)
        {
            return _al.ResponderPregunta(pregunta);
        }

        public void SetCalificacion(int calificacion)
        {
            _al.SetCalificacion(calificacion);
        }

        public bool SosIgual(IComparable comparable)
        {
            return _al.SosIgual(comparable);
        }

        public bool SosMayor(IComparable comparable)
        {
            return _al.SosMayor(comparable);
        }

        public bool SosMenor(IComparable comparable)
        {
            return _al.SosMenor(comparable);
        }
    }
}
