using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biur
{
    class Wycieczki:BiurPod
    {

        public Wycieczki() { }

        public Wycieczki(string kraj, string wyzywienie,int iloscosob, double cena,string data)
        {
            this.kraj = kraj;
            this.wyzywienie = wyzywienie;
            this.iloscosob = iloscosob;
            this.cena = cena;
            this.data = data;     
        }

        public override string Informacja()
        {
            return ("Kraj: " + this.kraj + "\nWyżywienie: " + this.wyzywienie + "\nIlość osób: " + this.iloscosob +"\nCena: "+this.cena +" zł"+ "\nData: " + this.data);
        }


    }
}
