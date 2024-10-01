using Metodologías_de_Programación_I.Interfaces;

namespace Metodologías_de_Programación_I.Clases.Adapter
{
    public class Teacher
    {
        public List<IStudent> students = new List<IStudent>(); //La hago publica para usar los decoradores en base a la lista completada por el teacher

        public void GoToClass(IStudent student)
        {
            students.Add(student);
        }

        public void TeachingAClass()
        {
            Random random = new Random();

            foreach (var student in students)
            {
                int calification = random.Next(2, 11);
                student.SetCalification(calification);
            }

            var sortedStudents = students.OrderByDescending(s => s.GetCalification()).ToList();
            foreach (var student in sortedStudents)
            {
                Console.WriteLine($"{student.GetName()} {student.GetCalification()}");
            }
        }
    }
}