using Metodologías_de_Programación_I.Interfaces;

namespace Metodologías_de_Programación_I.Clases.Decorator
{
    public class StudentDecorator : IStudent
    {
        protected IStudent student; 

        public StudentDecorator(IStudent student)
        {
            this.student = student;
        }

        public virtual string MostrarCalificacion()
        {
            return $"{student.GetName()} {student.GetCalification()}";
        }

        // Métodos de la interfaz IStudent
        public string GetName()
        {
            return student.GetName();
        }

        public int GetCalification()
        {
            return student.GetCalification();
        }

        public void SetCalification(int calification)
        {
            student.SetCalification(calification);
        }

        public int AnswerQuestion(int question)
        {
            return student.AnswerQuestion(question);
        }
    }
}
