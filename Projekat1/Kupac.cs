using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat1
{
    [Serializable]
    class Kupac : Korisnik
    {
      private  int id;
      private  string korisnickoIme, lozinka ;


        public Kupac(int id, string korisnickoIme, string lozinka, string ime, string prezime, string telefon, string jmbg, DateTime datumRodjenja):base( ime,  prezime,  telefon,  jmbg,  datumRodjenja) 
        {
            this.id = id;
            this.korisnickoIme = korisnickoIme;
            this.lozinka = lozinka;       
        }

        public int getID() {
            return id;
        }
        public string getKorisnickoIme() {
            return korisnickoIme;
        }

        public string getLozinka() {
            return lozinka;
        }

       

        public override string ToString()
        {
            return this.id.ToString() + " " + this.getIme() + " " + this.getPrezime();
        }

    }
}
