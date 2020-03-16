using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat1
{
    class Administrator : Korisnik
    {
        private int id;
        private string korisnickoIme, lozinka;

        public Administrator(int id, string korisnickoIme, string lozinka, string ime, 
            string prezime, string telefon, string jmbg, DateTime datumRodjenja):base(ime,prezime,telefon,jmbg,datumRodjenja)
        {
            this.id = id;
            this.korisnickoIme = korisnickoIme;
            this.lozinka = lozinka;
        }

        public int ID
        { get { return this.id; } }

        public string KorisnickoIme
        { get { return this.korisnickoIme; } }

        public string Lozinka
        { get { return this.lozinka; } }
    }
}
