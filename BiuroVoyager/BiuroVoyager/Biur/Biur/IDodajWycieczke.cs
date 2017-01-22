using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biur
{
    interface IDodajWycieczke//interfejs, będzie on potrzebny do Zamówienia gdzie będziemy musieli wpisać dane
    {
        void DodajWycieczke(string kraj, string wyzywienie, int iloscosob, double cena,string data);
    }
}
