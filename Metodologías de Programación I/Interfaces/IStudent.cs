namespace Metodologías_de_Programación_I.Interfaces
{
    public interface IStudent
    {
        string GetName();
        int GetCalification();
        void SetCalification(int calification);
        int AnswerQuestion(int question);
        string MostrarCalificacion();
    }
}
