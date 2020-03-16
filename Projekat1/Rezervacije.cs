using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat1
{
    [Serializable]
    class Rezervacije
    {
        int id_auta, id_kupca, cena;
        DateTime datum_od, datum_do;

        public Rezervacije(int id_auta, int id_kupca, int cena, DateTime datum_od, DateTime datum_do)
        {
            this.id_auta = id_auta;
            this.id_kupca = id_kupca;
            this.cena = cena;
            this.datum_od = datum_od;
            this.datum_do = datum_do;
        }

        public int getIDauta()
        {
            return this.id_auta;
        }

        public int getIDkupca()
        {
            return this.id_kupca;
        }

        public int getCena()
        {
            return this.cena;
        }

        public DateTime getDatumOd()
        {
            return this.datum_od;
        }

        public DateTime getDatumDO()
        {
            return this.datum_do;
        }
    }
}
