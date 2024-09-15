using Metodologías_de_Programación_I.Interfaces;
using IComparable = Metodologías_de_Programación_I.Interfaces.IComparable;

namespace Metodologías_de_Programación_I.Clases
{
    public class Persona : IComparable
    {
        private string Nombre;
        private int dni;
        IStrategyComparable strategyComparable;

        public Persona(string n, int d)
        {
            this.Nombre = n;
            this.dni = d;
        }

        public string getNombre() { return Nombre; }
        public int getDni() { return dni; }

        public virtual bool sosIgual(IComparable comparable)
        {
            Numero numero = (Numero)comparable;
            return this.dni == numero.getValor();
        }

        public virtual bool sosMenor(IComparable comparable)
        {
            Persona otraPersona = (Persona)comparable;
            return this.dni < otraPersona.getDni();
        }

        public virtual bool sosMayor(IComparable comparable)
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
