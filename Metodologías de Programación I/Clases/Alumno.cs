using Metodologías_de_Programación_I.Interfaces;
using Metodologías_de_Programación_I.Interfaces.Observer;
using IComparable = Metodologías_de_Programación_I.Interfaces.IComparable;

namespace Metodologías_de_Programación_I.Clases
{
    public class Alumno : Persona, IAlumnoObserver, IStudent
    {
        private int legajo;
        private double promedio;
        private int calificacion;
        public IStrategyComparable strategyComparable {  get; set; }

        private static Random random = new Random();

        private string[] distracciones = {
            "Mirando el celular",
            "Dibujando en el margen de la carpeta",
            "Tirando aviones de papel"
        };


        public int Calificacion
        {
            get { return calificacion; }
            set { calificacion = value; }
        }

        public Alumno(string n, int d, int l, double p, IStrategyComparable strategy) : base(n, d)
        {
            legajo = l;
            promedio = p;
            strategyComparable = strategy;
        }

        public Alumno(string n, int d, int legajo, double promedio) : base(n, d)
        {
        }

        public virtual int ResponderPregunta(int pregunta)
        {
            return random.Next(1, 4);
        }

        public string MostrarCalificacion()
        {
            return $"{this.getNombre()} {calificacion}";
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

        public void PrestarAtencion()
        {
            Console.WriteLine($"{this.getNombre()} está prestando atención.");
        }

        public void Distraerse()
        {
            int indice = random.Next(distracciones.Length);
            Console.WriteLine($"{this.getNombre()} se está distrayendo: {distracciones[indice]}.");
        }

        public string GetName()
        {
            return $"{this.getNombre()}";
        }

        public int GetCalification()
        {
            return this.Calificacion;
        }

        public void SetCalification(int calification)
        {
            this.Calificacion = calification;
        }

        public int AnswerQuestion(int question)
        {
            return this.ResponderPregunta(question);
        }
    }
}
