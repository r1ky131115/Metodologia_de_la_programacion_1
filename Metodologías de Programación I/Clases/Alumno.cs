using Metodologías_de_Programación_I.Interfaces;
using IComparable = Metodologías_de_Programación_I.Interfaces.IComparable;

namespace Metodologías_de_Programación_I.Clases
{
    public class Alumno : Persona
    {
        private int legajo;
        private double promedio;
        public IStrategyComparable strategyComparable {  get; set; }

        public Alumno(string n, int d, int l, double p, IStrategyComparable strategy) : base(n, d)
        {
            legajo = l;
            promedio = p;
            strategyComparable = strategy;
        }

        public int getLegajo()
        {
            return this.legajo;
        }

        public double getPromedio()
        {
            return this.promedio;
        }

        public override bool sosIgual(IComparable comparable)
        {
            //Alumno otroAlumno = (Alumno)comparable;
            //return this.legajo == otroAlumno.getLegajo();


            return strategyComparable.SosIgual(this, comparable);
        }

        public override bool sosMenor(IComparable comparable)
        {
            //Alumno otroAlumno = (Alumno)comparable;
            //return this.legajo < otroAlumno.getLegajo();
            return strategyComparable.SosMenor(this, comparable);
        }

        public override bool sosMayor(IComparable comparable)
        {
            //Alumno otroAlumno = (Alumno)comparable;
            //return this.legajo > otroAlumno.getLegajo();
            return strategyComparable.SosMayor(this, comparable);
        }

        public override string ToString()
        {
            return $"Nombre: {this.getNombre()} con Dni {this.getDni()}, legajo {this.getLegajo()} y un promedio de {this.getPromedio()}.";
        }

    }

}
