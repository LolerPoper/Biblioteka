using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    internal class Evidencija
    {
        string naziv_knjige, naziv_korisnika, datum_podizanja, datum_vracanja;

        public Evidencija(string naziv_knjige, string naziv_korisnika, string datum_podizanja, string datum_vracanja)
        {
            Naziv_knjige = naziv_knjige;
            Naziv_korisnika = naziv_korisnika;
            Datum_podizanja = datum_podizanja;
            Datum_vracanja = datum_vracanja;
        }

        public string Naziv_knjige { get => naziv_knjige; set => naziv_knjige = value; }
        public string Naziv_korisnika { get => naziv_korisnika; set => naziv_korisnika = value; }
        public string Datum_podizanja { get => datum_podizanja; set => datum_podizanja = value; }
        public string Datum_vracanja { get => datum_vracanja; set => datum_vracanja = value; }

        public override string ToString()
        {
            return "Knjiga: " + Naziv_knjige + "\r\tKorisnik: " + Naziv_korisnika + "\r\tDatum podizanja: " + Datum_podizanja 
                +  "\r\tDatum vračanja: " + Datum_vracanja;
        }
    }
}
