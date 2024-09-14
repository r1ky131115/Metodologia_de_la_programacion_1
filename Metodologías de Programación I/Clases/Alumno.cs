using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodologías_de_Programación_I.Clases
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

        public bool sosIgual(IComparable comparable)
        {
            Alumno otroAlumno = (Alumno)comparable;
            return this.legajo == otroAlumno.getLegajo();
        }

        public bool sosMenor(IComparable comparable)
        {
            Alumno otroAlumno = (Alumno)comparable;
            return this.legajo < otroAlumno.getLegajo();
        }

        public bool sosMayor(IComparable comparable)
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
