using Metodologias_de_Programacion_I_2024.Clases.Strategy;
using Metodologias_de_Programacion_I_2024.Interfaces;
using Metodologias_de_Programacion_I_2024.Interfaces.Strategy;

namespace Metodologias_de_Programacion_I_2024.Clases
{
    public class Alumno : Persona
    {
        private int legajo;
        private double promedio;
        private IStrategyAlumno strategyAlumno = new CompararPorDNI();

        public Alumno(string n, int d, int l, double p) : base(n, d)
        {
            legajo = l;
            promedio = p;
        }

        public void setStrategy(IStrategyAlumno strategy)
        {
            strategyAlumno = strategy;
        }

        public int getLegajo()
        {
            return legajo;
        }

        public double getPromedio()
        {
            return promedio;
        }

        public override bool SosIgual(Comparable comparable)
        {
            return strategyAlumno.SosMayor(this, comparable);
            //Alumno otroAlumno = (Alumno)comparable;
            //return this.legajo == otroAlumno.getLegajo();
        }

        public override bool SosMenor(Comparable comparable)
        {
            Alumno otroAlumno = (Alumno)comparable;
            return this.legajo < otroAlumno.getLegajo();
        }

        public virtual bool SosMayor(Comparable comparable)
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
