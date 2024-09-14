using Metodologías_de_Programación_I.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IComparable = Metodologías_de_Programación_I.Interfaces.IComparable;

namespace Metodologías_de_Programación_I.Clases
{
    public class Persona : IComparable
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

        public bool sosIgual(IComparable comparable)
        {
            Numero numero = (Numero)comparable;
            return this.dni == numero.getValor();
        }

        public bool sosMenor(IComparable comparable)
        {
            Persona otraPersona = (Persona)comparable;
            return this.dni < otraPersona.getDni();
        }

        public bool sosMayor(IComparable comparable)
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
