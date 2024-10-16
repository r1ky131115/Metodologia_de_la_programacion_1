using Metodologias_de_Programacion_I_2024.Interfaces;

namespace Metodologias_de_Programacion_I_2024.Clases
{
    public class Alumno : Persona
    {
        private int legajo;
        private double promedio;

        public Alumno(string n, int d, int l, double p) : base(n, d)
        {
            legajo = l;
            promedio = p;
        }

        public int getLegajo()
        {
            return legajo;
        }

        public double getPromedio()
        {
            return promedio;
        }

        public bool SosIgual(Comparable comparable)
        {
            Alumno otroAlumno = (Alumno)comparable;
            return this.legajo == otroAlumno.getLegajo();
        }

        public bool SosMenor(Comparable comparable)
        {
            Alumno otroAlumno = (Alumno)comparable;
            return this.legajo < otroAlumno.getLegajo();
        }

        public bool SosMayor(Comparable comparable)
        {
            Alumno otroAlumno = (Alumno)comparable;
            return this.legajo > otroAlumno.getLegajo();
        }

        public override string ToString()
        {
            return $"Nombre: {this.getNombre()} con Dni {this.getDni()}, legajo {this.getLegajo()} y un promedio de {this.getPromedio()}.";
        }

    }
}
