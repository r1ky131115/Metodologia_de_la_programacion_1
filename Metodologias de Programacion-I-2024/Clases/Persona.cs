using Metodologias_de_Programacion_I_2024.Interfaces;

namespace Metodologias_de_Programacion_I_2024.Clases
{
    public class Persona : Comparable
    {
        private string Nombre;
        private int dni;

        public Persona(string n, int d)
        {
            this.Nombre = n;
            this.dni = d;
        }

        public string getNombre() { return Nombre; }
        public int getDni() { return dni; }

        public bool SosIgual(Comparable comparable)
        {
            Numero numero = (Numero)comparable;
            return this.dni == numero.getValor();
        }

        public bool SosMenor(Comparable comparable)
        {
            Persona otraPersona = (Persona)comparable;
            return this.dni < otraPersona.getDni();
        }

        public bool SosMayor(Comparable comparable)
        {
            Persona otraPersona = (Persona)comparable;
            return this.dni > otraPersona.getDni();
        }

        public override string ToString()
        {
            return $"Nombre: {this.getNombre()} con Dni {this.getDni()}.";
        }
    }
}
