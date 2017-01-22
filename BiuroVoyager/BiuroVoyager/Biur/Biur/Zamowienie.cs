using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biur
{
    class Zamowienie:IDodajWycieczke
    //Służy głównie do opcji Zamówienie, gdzie będziemy wpisywać dane
    {
        private List<Wycieczki> zamowienie;

        public Zamowienie()
        {
            zamowienie = new List<Wycieczki>();
        }
        public void DodajWycieczke(string kraj, string wyzywienie, int iloscosob, double cena,string data)
        {
            zamowienie.Add(new Wycieczki(kraj, wyzywienie, iloscosob, cena, data));
        }
        public string PodajZawartosc()
        {
            string info = "Informacje:";
            foreach(var element in zamowienie)
            {
                info += Environment.NewLine + element.Informacja();
            }
            return info;
        }
        public void UsunWszystko()
        {
            zamowienie.Clear();
        }
    }
}
