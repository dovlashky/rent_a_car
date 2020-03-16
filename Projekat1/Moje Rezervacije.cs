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
    public partial class Moje_Rezervacije : Form
    {
        string fajl_lozinka;
        string fajl_kupac;
        string fajl_rezervacije;
        string fajl_auto;
        int id_selektovanog_auta;

        List<Kupac> kupci;
        List<Rezervacije> rezervacije;
        List<Automobil> automobili;
        public Moje_Rezervacije()
        {
            InitializeComponent();
            fajl_lozinka = "lozinka.txt";
            fajl_kupac = "kupci.bin";
            fajl_rezervacije = "rezervacije.bin";
            fajl_auto = "automobili.bin";
            kupci = new List<Kupac>();
            rezervacije = new List<Rezervacije>();
            automobili = new List<Automobil>();

            citanje_iz_fajla_kupac();
            citanje_iz_fajla_rezervacije();
            citanje_iz_fajla_automobil();

            inicijalizacija_kupca();
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
        private void inicijalizacija_kupca()
        {
            citanje_iz_fajla_automobil();
            citanje_iz_fajla_rezervacije();
            string lozinka = File.ReadAllText(fajl_lozinka);
            listboxRezervacije.Items.Add("Ponisti odabrano");
            for (int i = 0; i < kupci.Count; i++)
            {
                if (kupci[i].getLozinka() == lozinka)
                {
                    txtImeKupca.Text = kupci[i].getIme();
                    txtPrezimeKupca.Text = kupci[i].getPrezime();
                    txtJMBG.Text = kupci[i].getJmbg();
                    txtTelefon.Text = kupci[i].getTelefon();
                    txtDatRodjenja.Text = kupci[i].getDatumRodjenja().ToShortDateString();

                    for (int j = 0; j < rezervacije.Count; j++)
                    {
                        if (rezervacije[j].getIDkupca() == kupci[i].getID())
                        {
                            for (int z = 0; z < automobili.Count; z++)
                            {
                                if (rezervacije[j].getIDauta() == automobili[z].id)
                                {
                                    listboxRezervacije.Items.Add("ID:"+ " "+automobili[z].id + " "+ 
                                        automobili[z].marka + " " +
                                        automobili[z].model+ " " +
                                        rezervacije[j].getDatumOd().ToShortDateString()+ " - " +
                                        rezervacije[j].getDatumDO().ToShortDateString() + " Cena: " +
                                        rezervacije[j].getCena()+"din");
                                    
                                }
                            }
                        }
                    }
                }
            }

        }




        /***             Kod za prikaz podataka o rezervaciji   ************/

        
       

        private void ListboxRezervacije_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listboxRezervacije.SelectedItem != listboxRezervacije.Items[0])
            {
                string[] selektovani = listboxRezervacije.SelectedItem.ToString().Split(' ');
                id_selektovanog_auta = int.Parse(selektovani[1]);

                for (int i = 0; i < automobili.Count; i++)
                {
                    if (automobili[i].id == id_selektovanog_auta)
                    {

                        txtBrVrata.Text = automobili[i].brVrata;
                        txtKaroserija.Text = automobili[i].karoserija;
                        txtGodiste.Text = automobili[i].godiste.ToString();
                        txtGorivo.Text = automobili[i].gorivo;
                        txtMarka.Text = automobili[i].marka;
                        txtModel.Text = automobili[i].model;
                        txtMenjac.Text = automobili[i].menjac;
                        txtPogon.Text = automobili[i].pogon;
                        txtKubikaza.Text = automobili[i].kubikaza.ToString();

                    }

                }



                txtDatPreuzimanje.Text = selektovani[4];
                txtDatVracanje.Text = selektovani[6];
                txtCena.Text = selektovani[8];
            }
            else
            {
                txtBrVrata.Clear();
                txtKaroserija.Clear();
                txtGodiste.Clear();
                txtGorivo.Clear();
                txtMarka.Clear();
                txtModel.Clear();
                txtMenjac.Clear();
                txtPogon.Clear();
                txtKubikaza.Clear();

                txtDatPreuzimanje.Clear();
                txtDatVracanje.Clear();
                txtCena.Clear();
            }


            
        }


        /*****       Kod za ukidanje rezervacije           ***************/

        private void upis_u_fajl_rezervacije()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = File.OpenWrite(fajl_rezervacije);
            bf.Serialize(fs, rezervacije);
            MessageBox.Show("Uspesno uklonjena rezervacija.");
            fs.Dispose();
        }

        private void BtnUkini_Click(object sender, EventArgs e)
        {
            citanje_iz_fajla_rezervacije();
            if (listboxRezervacije.SelectedItem != null)
            {
                if (listboxRezervacije.SelectedItem != listboxRezervacije.Items[0])
                {
                    for (int i = 0; i < rezervacije.Count; i++)
                    {
                        if (id_selektovanog_auta == rezervacije[i].getIDauta() &&
                            rezervacije[i].getDatumOd().ToShortDateString() == txtDatPreuzimanje.Text &&
                            rezervacije[i].getDatumDO().ToShortDateString() == txtDatVracanje.Text)
                        {
                            rezervacije.RemoveAt(i);
                            upis_u_fajl_rezervacije();
                            citanje_iz_fajla_rezervacije();
                            listboxRezervacije.Items.Clear();
                            inicijalizacija_kupca();
                        }                       
                    }
                }
                else
                {
                    MessageBox.Show("Niste selektovali rezervaciju u listi.");
                }
            }
            else
            {
                MessageBox.Show("Niste selektovali rezervaciju u listi.");
            }
        }

        
        /*******             Kod za otvaranje forme za novu rezervaciju          *******/

        private void BtnNovaRez_Click(object sender, EventArgs e)
        {
            FrmRezervacija formaRezervacija = new FrmRezervacija();
            formaRezervacija.Show();
            this.Close();
        }
    }
}
