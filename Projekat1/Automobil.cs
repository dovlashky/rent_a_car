using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat1
{
    [Serializable]
    class Automobil
    {
        
        private int ID,  Godiste, Kubikaza;
        private string Marka, Model, Pogon, Menjac, Gorivo, BrVrata, Karoserija;

        public Automobil(int id, int godiste, int kubikaza, string marka, string model, string pogon, string menjac, string gorivo, string brVrata, string karoserija)
        {
            ID = id;
            Godiste = godiste;
            Kubikaza = kubikaza;
            Marka = marka;
            Model = model;
            Pogon = pogon;
            Menjac = menjac;
            Gorivo = gorivo;
            BrVrata = brVrata;
            Karoserija = karoserija;
        }

        public int id { get { return this.ID; } }
        public int godiste { get { return this.Godiste; } }

        public int kubikaza { get { return this.Kubikaza; } }

        public string marka { get { return this.Marka; } }

        public string model { get { return this.Model; } }

        public string pogon { get { return this.Pogon; } }

        public string menjac { get { return this.Menjac; } }

        public string gorivo { get { return this.Gorivo; } }

        public string brVrata { get { return this.BrVrata; } }

        public string karoserija { get { return this.Karoserija; } }

        public override string ToString()
        {
            return this.ID + " " + Marka + " " + Model;
        }
    }

    
}
