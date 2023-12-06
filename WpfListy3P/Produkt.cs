using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfListy3P
{
    public class Produkt
    {
        public string Nazwa { get; set; }
        public double Cena { get; set; }
        public string Opis { get; set; }
        public bool Dostepny { get; set; }
        public String Kategoria { get; set; }

        public Produkt(string nazwa, double cena, string opis, bool dostepny)
        {
            Nazwa = nazwa;
            Cena = cena;
            Opis = opis;
            Dostepny = dostepny;
            Kategoria = "Dla każdego";
        }

        public Produkt(string nazwa, double cena, string opis, bool dostepny, string kategoria) : this(nazwa, cena, opis, dostepny)
        {
            Kategoria = kategoria;
        }
    }
}
