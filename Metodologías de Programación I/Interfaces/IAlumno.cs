namespace Metodologías_de_Programación_I.Interfaces
{
    public interface IAlumno : IComparable
    {
        int GetCalificacion();

        int GetLegajo();

        string GetNombre();

        int GetDni();

        int GetPromerdio();

        void SetCalificacion(int calificacion);

        int ResponderPregunta(int pregunta);

        string MostrarCalificacion();

        void PrestarAtencion();

        void Distraerse();
    }
}
