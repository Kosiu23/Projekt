using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biur
{
    class Szczegoly:Wycieczki
    //Potrzebna do szczegółów wycieczek
    {
        string opis;
        string hotel;
        public Szczegoly(string kraj,string hotel,string opis)
        {
            this.kraj = kraj;
            this.hotel = hotel;
            this.opis = opis;
            
        }
        public override string Informacja()
        {
            return ("Kraj: " + this.kraj + "\nHotel: " + this.hotel + "\nOpis: " + this.opis);
        }
    }
}
