using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodologías_de_Programación_I.Clases.Template_Method
{
    public abstract class CardsGame
    {
        public abstract void MezclarMazo();
        public abstract void RepartirCartasIniciales();
        public abstract void TomarUnaCarta();
        public abstract void DescartarUnaCarta();
        public abstract void JugarUnaMano();

    }
}
