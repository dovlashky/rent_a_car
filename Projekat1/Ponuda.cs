using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat1
{
    [Serializable]
    class Ponuda
    {
        private int id, cena;
        private DateTime datum_od, datum_do;

        public Ponuda(int id, int cena, DateTime datum_od, DateTime datum_do)
        {
            this.id = id;
            this.cena = cena;
            this.datum_od = datum_od;
            this.datum_do = datum_do;
        }

        public int ID
        {
            get {
                return this.id;
            }
        }


        public int Cena
        {
            get
            {
                return this.cena;
            }
        }

        public DateTime getDatumOd()
        { return datum_od; }

        public DateTime getDatumDo()
        { return datum_do; }
    }
}
