using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekat1
{
    public partial class FrmRezervacija : Form
    {
        string fajl_lozinka;
        string lozinka;
        int id_kupca;

        List<Kupac> kupci;
        string fajl_kupac;
        public FrmRezervacija()
        {
            InitializeComponent();
            automobili = new List<Automobil>();
            fajl_auto = "automobili.bin";
            citanje_iz_fajla_automobil();
            citanje_u_kombo_Marka();

            ponuda = new List<Ponuda>();
            fajl_ponuda = "ponuda.bin";
            

            rezervacije = new List<Rezervacije>();
            fajl_rezervacije = "rezervacije.bin";

            fajl_lozinka = "lozinka.txt";
            lozinka = File.ReadAllText(fajl_lozinka);

            kupci = new List<Kupac>();
            fajl_kupac = "kupci.bin";
            inicijalizacija_id_kupca();
        }

        private void citanje_iz_fajla_kupac()
        {
            if (File.Exists(fajl_kupac))
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = File.OpenRead(fajl_kupac);
                kupci = bf.Deserialize(fs) as List<Kupac>;
                fs.Dispose();
            }
        }
        private void inicijalizacija_id_kupca()
        {
            citanje_iz_fajla_kupac();
            for (int i = 0; i < kupci.Count; i++)
            {
                if (lozinka == kupci[i].getLozinka())
                {
                    id_kupca = kupci[i].getID();
                }
            }
        }

        /************             Kod za odabiranje auta    *************/

        List<Automobil> automobili;
        string fajl_auto;

        private void citanje_iz_fajla_automobil()
        {
            if (File.Exists(fajl_auto))
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = File.OpenRead(fajl_auto);
                automobili = bf.Deserialize(fs) as List<Automobil>;
                fs.Dispose();
            }
        }

        private void citanje_u_kombo_Marka()
        {
            citanje_iz_fajla_automobil();
            List<string> marke = new List<string>();

                                    
            for (int i = 0; i < automobili.Count; i++)
            {
                marke.Add(automobili[i].marka);                
            }

            IEnumerable<string> DistinctMarke = marke.Distinct();

            List<string> markeSkraceno = new List<string>();
            
            foreach (string marka in DistinctMarke)
            {
                markeSkraceno.Add(marka);
            }

            Sortiranje element = new Sortiranje();
            markeSkraceno.Sort(element);
            for (int i = 0; i < markeSkraceno.Count; i++)
            {
                cmbMarka.Items.Add(markeSkraceno[i]);
            }


        }

        private void citanje_u_kombo_Model()
        {
            citanje_iz_fajla_automobil();
            List<string> modeli = new List<string>();
            
            for (int i = 0; i < automobili.Count; i++)
            {
                if (automobili[i].marka == (string)cmbMarka.SelectedItem)
                {
                    modeli.Add(automobili[i].model);
                }
            }

            IEnumerable<string> DistinctModeli =modeli.Distinct();

            List<string> modeliSkraceno = new List<string>();

            foreach (string model in DistinctModeli)
            {
                modeliSkraceno.Add(model);
            }

            Sortiranje element = new Sortiranje();
            modeliSkraceno.Sort(element);
            for (int i = 0; i < modeliSkraceno.Count; i++)
            {
                cmbModel.Items.Add(modeliSkraceno[i]);
            }



        }
   
        private void CmbMarka_SelectedValueChanged(object sender, EventArgs e)
        {
            
            cmbModel.Text = "";
            cmbModel.Items.Clear();
            cmbGodiste.Text = "";
            cmbGodiste.Items.Clear();
            cmbKubikaza.Text = "";
            cmbKubikaza.Items.Clear();
            cmbKaroserija.Text = "";
            cmbKaroserija.Items.Clear();
            cmbBrVrata.Text = "";
            cmbBrVrata.Items.Clear();
            cmbGorivo.Text = "";
            cmbGorivo.Items.Clear();
            cmbPogon.Text = "";
            cmbPogon.Items.Clear();
            cmbMenjac.Text = "";
            cmbMenjac.Items.Clear();
            citanje_u_kombo_Model();            
        }

       
        private void CmbModel_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbGodiste.Text = "";
            cmbGodiste.Items.Clear();
            cmbKubikaza.Text = "";
            cmbKubikaza.Items.Clear();
            cmbKaroserija.Text = "";
            cmbKaroserija.Items.Clear();
            cmbBrVrata.Text = "";
            cmbBrVrata.Items.Clear();
            cmbGorivo.Text = "";
            cmbGorivo.Items.Clear();
            cmbPogon.Text = "";
            cmbPogon.Items.Clear();
            cmbMenjac.Text = "";
            cmbMenjac.Items.Clear();
            citanje_iz_fajla_automobil();
            List<int> godista = new List<int>();

            for (int i = 0; i < automobili.Count; i++)
            {
                if (automobili[i].marka == (string)cmbMarka.SelectedItem && 
                    automobili[i].model == (string)cmbModel.SelectedItem )
                {
                    godista.Add(automobili[i].godiste);
                }
            }

            IEnumerable<int> DistinctGodista = godista.Distinct();

            List<int> godistaSkraceno = new List<int>();

            foreach (int god in DistinctGodista)
            {
                godistaSkraceno.Add(god);
            }

            Sortiranje_brojeva element = new Sortiranje_brojeva();
            godistaSkraceno.Sort(element);
            for (int i = 0; i < godistaSkraceno.Count; i++)
            {
                cmbGodiste.Items.Add(godistaSkraceno[i]);
            }
        }

        private void CmbGodiste_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbKubikaza.Text = "";
            cmbKubikaza.Items.Clear();
            cmbKaroserija.Text = "";
            cmbKaroserija.Items.Clear();
            cmbBrVrata.Text = "";
            cmbBrVrata.Items.Clear();
            cmbGorivo.Text = "";
            cmbGorivo.Items.Clear();
            cmbPogon.Text = "";
            cmbPogon.Items.Clear();
            cmbMenjac.Text = "";
            cmbMenjac.Items.Clear();
            citanje_iz_fajla_automobil();
            List<int> kubikaze = new List<int>();

            for (int i = 0; i < automobili.Count; i++)
            {
                if (automobili[i].marka == (string)cmbMarka.SelectedItem &&
                    automobili[i].model == (string)cmbModel.SelectedItem &&
                    automobili[i].godiste == (int)cmbGodiste.SelectedItem)
                {
                    kubikaze.Add(automobili[i].kubikaza);
                }
            }

            IEnumerable<int> DistinctKubikaze = kubikaze.Distinct();

            List<int> kubikazeSkraceno = new List<int>();

            foreach (int kubikaza in DistinctKubikaze)
            {
                kubikazeSkraceno.Add(kubikaza);
            }

            Sortiranje_brojeva element = new Sortiranje_brojeva();
            kubikazeSkraceno.Sort(element);
            for (int i = 0; i < kubikazeSkraceno.Count; i++)
            {
                cmbKubikaza.Items.Add(kubikazeSkraceno[i]);
            }
        }

        private void CmbKubikaza_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbKaroserija.Text = "";
            cmbKaroserija.Items.Clear();
            cmbBrVrata.Text = "";
            cmbBrVrata.Items.Clear();
            cmbGorivo.Text = "";
            cmbGorivo.Items.Clear();
            cmbPogon.Text = "";
            cmbPogon.Items.Clear();
            cmbMenjac.Text = "";
            cmbMenjac.Items.Clear();
            citanje_iz_fajla_automobil();
            List<string> karoserije = new List<string>();

            for (int i = 0; i < automobili.Count; i++)
            {
                if (automobili[i].marka == (string)cmbMarka.SelectedItem &&
                    automobili[i].model == (string)cmbModel.SelectedItem &&
                    automobili[i].godiste == (int)cmbGodiste.SelectedItem &&
                    automobili[i].kubikaza == (int)cmbKubikaza.SelectedItem)
                {
                    karoserije.Add(automobili[i].karoserija);
                }
            }

            IEnumerable<string> DistinctKaroserije = karoserije.Distinct();

            List<string> karoserijeSkraceno = new List<string>();

            foreach (string karoserija in DistinctKaroserije)
            {
                karoserijeSkraceno.Add(karoserija);
            }

            Sortiranje element = new Sortiranje();
            karoserijeSkraceno.Sort(element);
            for (int i = 0; i < karoserijeSkraceno.Count; i++)
            {
                cmbKaroserija.Items.Add(karoserijeSkraceno[i]);
            }


        }

        private void CmbKaroserija_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbBrVrata.Text = "";
            cmbBrVrata.Items.Clear();
            cmbGorivo.Text = "";
            cmbGorivo.Items.Clear();
            cmbPogon.Text = "";
            cmbPogon.Items.Clear();
            cmbMenjac.Text = "";
            cmbMenjac.Items.Clear();
            citanje_iz_fajla_automobil();
            List<string> brVrata = new List<string>();

            for (int i = 0; i < automobili.Count; i++)
            {
                if (automobili[i].marka == (string)cmbMarka.SelectedItem &&
                    automobili[i].model == (string)cmbModel.SelectedItem &&
                    automobili[i].godiste == (int)cmbGodiste.SelectedItem &&
                    automobili[i].kubikaza == (int)cmbKubikaza.SelectedItem &&
                    automobili[i].karoserija == (string)cmbKaroserija.SelectedItem)
                {
                    brVrata.Add(automobili[i].brVrata);
                }
            }

            IEnumerable<string> DistinctBrVrata = brVrata.Distinct();

            List<string> brVrataSkraceno = new List<string>();

            foreach (string brvr in DistinctBrVrata)
            {
                brVrataSkraceno.Add(brvr);
            }

            Sortiranje element = new Sortiranje();
            brVrataSkraceno.Sort(element);
            for (int i = 0; i < brVrataSkraceno.Count; i++)
            {
                cmbBrVrata.Items.Add(brVrataSkraceno[i]);
            }

        }

        private void CmbBrVrata_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbGorivo.Text = "";
            cmbGorivo.Items.Clear();
            cmbPogon.Text = "";
            cmbPogon.Items.Clear();
            cmbMenjac.Text = "";
            cmbMenjac.Items.Clear();
            citanje_iz_fajla_automobil();
            List<string> goriva = new List<string>();

            for (int i = 0; i < automobili.Count; i++)
            {
                if (automobili[i].marka == (string)cmbMarka.SelectedItem &&
                    automobili[i].model == (string)cmbModel.SelectedItem &&
                    automobili[i].godiste == (int)cmbGodiste.SelectedItem &&
                    automobili[i].kubikaza == (int)cmbKubikaza.SelectedItem &&
                    automobili[i].karoserija == (string)cmbKaroserija.SelectedItem &&
                    automobili[i].brVrata == (string)cmbBrVrata.SelectedItem)
                {
                    goriva.Add(automobili[i].gorivo);
                }
            }

            IEnumerable<string> DistinctGoriva = goriva.Distinct();

            List<string> gorivaSkraceno = new List<string>();

            foreach (string gorivo in DistinctGoriva)
            {
                gorivaSkraceno.Add(gorivo);
            }

            Sortiranje element = new Sortiranje();
            gorivaSkraceno.Sort(element);
            for (int i = 0; i < gorivaSkraceno.Count; i++)
            {
                cmbGorivo.Items.Add(gorivaSkraceno[i]);
            }

        }

        private void CmbGorivo_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbPogon.Text = "";
            cmbPogon.Items.Clear();
            cmbMenjac.Text = "";
            cmbMenjac.Items.Clear();
            citanje_iz_fajla_automobil();
            List<string> pogoni = new List<string>();

            for (int i = 0; i < automobili.Count; i++)
            {
                if (automobili[i].marka == (string)cmbMarka.SelectedItem &&
                    automobili[i].model == (string)cmbModel.SelectedItem &&
                    automobili[i].godiste == (int)cmbGodiste.SelectedItem &&
                    automobili[i].kubikaza == (int)cmbKubikaza.SelectedItem &&
                    automobili[i].karoserija == (string)cmbKaroserija.SelectedItem &&
                    automobili[i].brVrata == (string)cmbBrVrata.SelectedItem &&
                    automobili[i].gorivo == (string)cmbGorivo.SelectedItem)
                {
                    pogoni.Add(automobili[i].pogon);
                }
            }

            IEnumerable<string> DistinctPogoni = pogoni.Distinct();

            List<string> pogoniSkraceno = new List<string>();

            foreach (string pogon in DistinctPogoni)
            {
                pogoniSkraceno.Add(pogon);
            }

            Sortiranje element = new Sortiranje();
            pogoniSkraceno.Sort(element);
            for (int i = 0; i < pogoniSkraceno.Count; i++)
            {
                cmbPogon.Items.Add(pogoniSkraceno[i]);
            }


        }

        private void CmbPogon_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbMenjac.Text = "";
            cmbMenjac.Items.Clear();
            citanje_iz_fajla_automobil();
            List<string> menjaci = new List<string>();

            for (int i = 0; i < automobili.Count; i++)
            {
                if (automobili[i].marka == (string)cmbMarka.SelectedItem &&
                    automobili[i].model == (string)cmbModel.SelectedItem &&
                    automobili[i].godiste == (int)cmbGodiste.SelectedItem &&
                    automobili[i].kubikaza == (int)cmbKubikaza.SelectedItem &&
                    automobili[i].karoserija == (string)cmbKaroserija.SelectedItem &&
                    automobili[i].brVrata == (string)cmbBrVrata.SelectedItem &&
                    automobili[i].gorivo == (string)cmbGorivo.SelectedItem &&
                    automobili[i].pogon == (string)cmbPogon.SelectedItem)
                {
                    cmbMenjac.Items.Add(automobili[i].menjac);
                }
            }

            IEnumerable<string> DistinctMenjaci = menjaci.Distinct();

            List<string> menjaciSkraceno = new List<string>();

            foreach (string menjac in DistinctMenjaci)
            {
                menjaciSkraceno.Add(menjac);
            }

            Sortiranje element = new Sortiranje();
            menjaciSkraceno.Sort(element);
            for (int i = 0; i < menjaciSkraceno.Count; i++)
            {
                cmbMenjac.Items.Add(menjaciSkraceno[i]);
            }

        }


        /************************** KOD za prikaz termina *****************/


        List<Ponuda> ponuda;
        string fajl_ponuda;

        private void citanje_iz_fajla_ponuda()
        {
            if (File.Exists(fajl_ponuda))
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = File.OpenRead(fajl_ponuda);
                ponuda = bf.Deserialize(fs) as List<Ponuda>;
                fs.Dispose();
            }
        }
        private void BtnPrikaziTermine_Click(object sender, EventArgs e)
        {
            txtPrikazTermina.Text = "";
            citanje_iz_fajla_ponuda();
            citanje_iz_fajla_automobil();
            int id_odabranog = -1;
            int greska = 0;

          
            for (int i = 0; i < automobili.Count; i++)
            {
                if (automobili[i].marka == (string)cmbMarka.SelectedItem &&
                    automobili[i].model == (string)cmbModel.SelectedItem &&
                    automobili[i].godiste == (int)cmbGodiste.SelectedItem &&
                    automobili[i].kubikaza == (int)cmbKubikaza.SelectedItem &&
                    automobili[i].karoserija == (string)cmbKaroserija.SelectedItem &&
                    automobili[i].brVrata == (string)cmbBrVrata.SelectedItem &&
                    automobili[i].gorivo == (string)cmbGorivo.SelectedItem &&
                    automobili[i].pogon == (string)cmbPogon.SelectedItem &&
                    automobili[i].menjac == (string)cmbMenjac.SelectedItem)
                {
                    id_odabranog = automobili[i].id;
                    greska = 0;
                    break;
                }
                else
                {
                    greska++;                    
                }
            }

            if (greska != 0 )
            {
                MessageBox.Show("Niste izabrali sve kategorije za vozilo.");
            }

            if (greska == 0)
            {
                for (int i = 0; i < ponuda.Count; i++)
                {
                    if (id_odabranog == ponuda[i].ID)
                    {
                        txtPrikazTermina.AppendText(ponuda[i].getDatumOd().ToShortDateString() +
                            " - " + ponuda[i].getDatumDo().ToShortDateString() +
                            " " + "Cena:" + " " + ponuda[i].Cena + " din po danu "
                            + Environment.NewLine);
                        ;
                    }
                }
            }
            
        }


        /******              Kod za rezervisanje                     *******/

        List<Rezervacije> rezervacije;
        string fajl_rezervacije;

        private void upis_u_fajl_rezervacije()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = File.OpenWrite(fajl_rezervacije);
            bf.Serialize(fs, rezervacije);
            MessageBox.Show("Uspesno uneta rezervacija.");
            fs.Dispose();
        }
        private void citanje_iz_fajla_rezervacije()
        {
            if (File.Exists(fajl_rezervacije))
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = File.OpenRead(fajl_rezervacije);
                rezervacije = bf.Deserialize(fs) as List<Rezervacije>;
                fs.Dispose();
            }
        }

        private void upis_u_fajl_ponuda()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = File.OpenWrite(fajl_ponuda);
            bf.Serialize(fs, ponuda);
            fs.Dispose();
        }

        private void BtnRezervisi_Click(object sender, EventArgs e)

        {
            citanje_iz_fajla_ponuda();
            citanje_iz_fajla_automobil();
            int greska_izbora = 0;
            int id_odabranog_auta = -1;

            for (int i = 0; i < automobili.Count; i++)
            {
                if (automobili[i].marka == (string)cmbMarka.SelectedItem &&
                    automobili[i].model == (string)cmbModel.SelectedItem &&
                    automobili[i].godiste == (int)cmbGodiste.SelectedItem &&
                    automobili[i].kubikaza == (int)cmbKubikaza.SelectedItem &&
                    automobili[i].karoserija == (string)cmbKaroserija.SelectedItem &&
                    automobili[i].brVrata == (string)cmbBrVrata.SelectedItem &&
                    automobili[i].gorivo == (string)cmbGorivo.SelectedItem &&
                    automobili[i].pogon == (string)cmbPogon.SelectedItem &&
                    automobili[i].menjac == (string)cmbMenjac.SelectedItem)
                {
                    id_odabranog_auta = automobili[i].id;
                    greska_izbora = 0;
                    break;
                }
                else
                {
                    greska_izbora++;                   
                }
            }

            if (greska_izbora != 0)
            {
                MessageBox.Show("Niste izabrali sve kategorije za vozilo.");
            }

            DateTime preuzimanje = dateTimePreuzimanje.Value.Date;
            DateTime vracanje = dateTimeVracanje.Value.Date;

            int greska_opsega = 0;
            int greska_termin = 0;

            if (greska_izbora == 0)
            {
                if (preuzimanje > vracanje)
                {
                    greska_opsega++;
                    MessageBox.Show("Uneli ste neodgovarajuci opseg datuma.");
                    txtUkupnaCena.Text = "";
                }
            }
            

            

            if (greska_opsega == 0 && greska_izbora == 0)
            {
                for (int i = 0; i < ponuda.Count; i++)
                {

                    if (id_odabranog_auta == ponuda[i].ID &&
                       preuzimanje >= ponuda[i].getDatumOd().Date && vracanje <= ponuda[i].getDatumDo().Date
                       )
                    {
                        TimeSpan t = vracanje.Subtract(preuzimanje);
                        double cena = (t.TotalDays + 1) * ponuda[i].Cena;

                        citanje_iz_fajla_rezervacije();
                        Rezervacije r = new Rezervacije(id_odabranog_auta, id_kupca, (int)cena, preuzimanje, vracanje);
                        rezervacije.Add(r);
                        upis_u_fajl_rezervacije();

                        txtPrikazTermina.Clear();
                        txtUkupnaCena.Clear();
                    
                        if (preuzimanje == ponuda[i].getDatumOd().Date && vracanje == ponuda[i].getDatumDo().Date)
                        {
                            ponuda.RemoveAt(i);
                            upis_u_fajl_ponuda();
                        }
                        
                            if (preuzimanje == ponuda[i].getDatumOd().Date && vracanje < ponuda[i].getDatumDo().Date)
                            {
                                Ponuda p1 = new Ponuda(id_odabranog_auta, ponuda[i].Cena,
                                vracanje.AddDays(1), ponuda[i].getDatumDo());
                                ponuda.Add(p1);
                                
                                ponuda.RemoveAt(i);
                                upis_u_fajl_ponuda();
                            }

                            if (preuzimanje > ponuda[i].getDatumOd().Date && vracanje == ponuda[i].getDatumDo().Date)
                            {
                                Ponuda p1 = new Ponuda(id_odabranog_auta, ponuda[i].Cena,
                                ponuda[i].getDatumOd(), preuzimanje.AddDays(-1));
                                ponuda.Add(p1);
                               
                                ponuda.RemoveAt(i);
                                upis_u_fajl_ponuda();
                            }

                            if (preuzimanje > ponuda[i].getDatumOd().Date && vracanje < ponuda[i].getDatumDo().Date)
                            {
                                Ponuda p1 = new Ponuda(id_odabranog_auta, ponuda[i].Cena,
                                ponuda[i].getDatumOd(), preuzimanje.AddDays(-1));
                                ponuda.Add(p1);

                                Ponuda p2 = new Ponuda(id_odabranog_auta, ponuda[i].Cena,
                                    vracanje.AddDays(+1), ponuda[i].getDatumDo());
                                ponuda.Add(p2);

                                ponuda.RemoveAt(i);
                                upis_u_fajl_ponuda();
                            }

                        this.Close();
                        Moje_Rezervacije frmMojeRez = new Moje_Rezervacije();
                        frmMojeRez.Show();
                        greska_termin = 0;                     
                        break;
                    }
                    else
                    {                        
                        greska_termin++;                      
                    }
                }

                
            }

            if (greska_termin!=0)
            {
                MessageBox.Show("Nema termina u izabranom opsegu datuma.");
            }

            

        }

        private void DateTimePreuzimanje_ValueChanged(object sender, EventArgs e)

        {
            citanje_iz_fajla_ponuda();
            citanje_iz_fajla_automobil();

            int id_odabranog_auta = -1;
            

            for (int i = 0; i < automobili.Count; i++)
            {
                if (automobili[i].marka == (string)cmbMarka.SelectedItem &&
                    automobili[i].model == (string)cmbModel.SelectedItem &&
                    automobili[i].godiste == (int)cmbGodiste.SelectedItem &&
                    automobili[i].kubikaza == (int)cmbKubikaza.SelectedItem &&
                    automobili[i].karoserija == (string)cmbKaroserija.SelectedItem &&
                    automobili[i].brVrata == (string)cmbBrVrata.SelectedItem &&
                    automobili[i].gorivo == (string)cmbGorivo.SelectedItem &&
                    automobili[i].pogon == (string)cmbPogon.SelectedItem &&
                    automobili[i].menjac == (string)cmbMenjac.SelectedItem)
                {
                    id_odabranog_auta = automobili[i].id;
                }
            }

            DateTime preuzimanje = dateTimePreuzimanje.Value.Date;
            DateTime vracanje = dateTimeVracanje.Value.Date;


            if (preuzimanje > vracanje)
            {
                txtUkupnaCena.Text = "";
            }
            else
            {
                for (int i = 0; i < ponuda.Count; i++)
                {

                    if (id_odabranog_auta == ponuda[i].ID &&
                       preuzimanje >= ponuda[i].getDatumOd().Date && vracanje <= ponuda[i].getDatumDo().Date
                       )
                    {
                        TimeSpan t = vracanje.Subtract(preuzimanje);
                        double cena = (t.TotalDays + 1) * ponuda[i].Cena;
                        txtUkupnaCena.Text = cena.ToString();
                        break;

                    }
                    else
                    {
                        txtUkupnaCena.Clear();
                    }
                }
            }

           
           

            
            
        }

        private void DateTimeVracanje_ValueChanged(object sender, EventArgs e)

        {
            citanje_iz_fajla_ponuda();
            citanje_iz_fajla_automobil();

            int id_odabranog_auta = -1;


            for (int i = 0; i < automobili.Count; i++)
            {
                if (automobili[i].marka == (string)cmbMarka.SelectedItem &&
                    automobili[i].model == (string)cmbModel.SelectedItem &&
                    automobili[i].godiste == (int)cmbGodiste.SelectedItem &&
                    automobili[i].kubikaza == (int)cmbKubikaza.SelectedItem &&
                    automobili[i].karoserija == (string)cmbKaroserija.SelectedItem &&
                    automobili[i].brVrata == (string)cmbBrVrata.SelectedItem &&
                    automobili[i].gorivo == (string)cmbGorivo.SelectedItem &&
                    automobili[i].pogon == (string)cmbPogon.SelectedItem &&
                    automobili[i].menjac == (string)cmbMenjac.SelectedItem)
                {
                    id_odabranog_auta = automobili[i].id;
                }
            }

            DateTime preuzimanje = dateTimePreuzimanje.Value.Date;
            DateTime vracanje = dateTimeVracanje.Value.Date;

            if (preuzimanje > vracanje)
            {
                txtUkupnaCena.Text = "";
            }
            else
            {
                for (int i = 0; i < ponuda.Count; i++)
                {

                    if (id_odabranog_auta == ponuda[i].ID &&
                       preuzimanje >= ponuda[i].getDatumOd().Date && vracanje <= ponuda[i].getDatumDo().Date
                       )
                    {
                        TimeSpan t = vracanje.Subtract(preuzimanje);
                        double cena = (t.TotalDays + 1) * ponuda[i].Cena;
                        txtUkupnaCena.Text = cena.ToString();
                        break;

                    }
                    else
                    {
                        txtUkupnaCena.Clear();
                    }
                }
            }

        }
    }
}
