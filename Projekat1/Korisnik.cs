using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat1
{
    [Serializable]
    class Korisnik
    {
         private string Ime, Prezime, Jmbg, Telefon;        
       private DateTime DatumRodjenja;

        public Korisnik(string ime, string prezime, string telefon, string jmbg, DateTime datumRodjenja)
        {
            Ime = ime;
            Prezime = prezime;
            Telefon = telefon;
            Jmbg = jmbg;
            DatumRodjenja = datumRodjenja;
        }

        public string getIme() {
            return Ime;
        }

        public string getPrezime()
        {
            return Prezime;
        }

        public string getTelefon()
        {
            return Telefon;
        }

        public string getJmbg()
        {
            return Jmbg;
        }

        public DateTime getDatumRodjenja()
        {
            return DatumRodjenja;
        }

        public override string ToString()
        {
            return this.Ime + " " + this.Prezime;
        }
    }
}
