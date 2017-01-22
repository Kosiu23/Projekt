using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biur
{
    public abstract class BiurPod//abstrakcyjna klasa zostanie wykorzystana dla wycieczki,
    //możliwe przesłaniania metod dzięki niej
    {
        protected string kraj;
        protected string wyzywienie;
        protected int iloscosob;
        protected double cena;
        protected string data;

        public abstract string Informacja();
    }
}
