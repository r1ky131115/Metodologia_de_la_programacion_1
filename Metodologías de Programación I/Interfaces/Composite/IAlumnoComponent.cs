namespace Metodologías_de_Programación_I.Interfaces.Composite
{
    public interface IAlumnoComponent
    {
        string getNombre();
        string responderPregunta();
        void setCalificacion(int calificacion);
        void mostrarCalificacion();
        bool sosIgual(IAlumnoComponent alumno);
        bool sosMenor(IAlumnoComponent alumno);
        bool sosMayor(IAlumnoComponent alumno);
    }
}
