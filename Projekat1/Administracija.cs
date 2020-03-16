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
    public partial class FrmAdministracija : Form
    {




        public FrmAdministracija()
        {
            InitializeComponent();
            /* automobil */

            automobili = new List<Automobil>();
            putanja = "automobili.bin";


            IncijalizujListu();

            /*kupac*/
            kupci = new List<Kupac>();
            fajl = "kupci.bin";
            dodaj_u_listboxKupac();
            greska_selektovanja = 1;

            /* ponuda */
            citanje_iz_fajla_automobili();

            ponuda = new List<Ponuda>();
            fajl_ponuda = "ponuda.bin";
            inicijalizacija_spiska_auta();
            greska_selektovanja_auta_ponuda = 1;

            /* rezervacije */
            inicijalizacija_kupaca();
            rezervacije = new List<Rezervacije>();
            fajl_rezervacije = "rezervacije.bin";

            /* statistika */
           
            inicijalizuj_format_vremena();
            inicijalizuj_komboboks_Marka1();
           

        }

        /****          KOD za automobil               ******/

        List<Automobil> automobili;
        string putanja;
        int id_selektovanog_auta;

        private void citanje_iz_fajla_automobili()
        {
            if (File.Exists(putanja))
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = File.OpenRead(putanja);
                automobili = bf.Deserialize(fs) as List<Automobil>;
                fs.Dispose();
            }
        }

        private void upis_u_fajl_automobil()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = File.OpenWrite(putanja);
            bf.Serialize(fs, automobili);
            fs.Dispose();
        }
        public void IncijalizujListu()
        {
            citanje_iz_fajla_automobili();
            listAutaSvi.Items.Add("Ponisti odabrano");
            for (int i = 0; i < automobili.Count; i++)
            {
                listAutaSvi.Items.Add("ID:" + " " + automobili[i].id + " - " + automobili[i].marka + "-" +
                    automobili[i].model + "-Godiste: " + automobili[i].godiste + " ...");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            citanje_iz_fajla_automobili();
            int praznaPolja = 0;
            int pogresanUnos = 0;


            if (txtID.Text.Trim().Length == 0)
            {
                praznaPolja++;
            }

            if (txtGodiste.Text.Trim().Length == 0)
            {
                praznaPolja++;
            }

            if (txtMarka.Text.Trim().Length == 0)
            {
                praznaPolja++;

            }

            if (txtModel.Text.Trim().Length == 0)
            {
                praznaPolja++;
            }

            if (txtKubikaza.Text.Trim().Length == 0)
            {
                praznaPolja++;
            }

            if (txtPogon.Text.Trim().Length == 0)
            {
                praznaPolja++;
            }

            if (txtMenjac.Text.Trim().Length == 0)
            {
                praznaPolja++;
            }

            if (txtKaroserija.Text.Trim().Length == 0)
            {
                praznaPolja++;
            }

            if (txtGorivo.Text.Trim().Length == 0)
            {
                praznaPolja++;
            }

            if (txtBrVrata.Text.Trim().Length == 0)
            {
                praznaPolja++;
            }

            if (praznaPolja != 0)
            {
                MessageBox.Show("Popunite sva polja");
            }

            if (praznaPolja == 0)
            {

                if (int.TryParse(txtID.Text, out int broj) == false)
                {
                    MessageBox.Show("Za ID unesite samo cifre");
                    pogresanUnos++;
                }


                if (int.TryParse(txtGodiste.Text, out broj) == false)
                {
                    MessageBox.Show("Za godiste unesite samo cifre");
                    pogresanUnos++;
                }

                if (int.TryParse(txtKubikaza.Text, out broj) == false)
                {
                    MessageBox.Show("Za kubikazu unesite samo cifre");
                    pogresanUnos++;
                }

                for (int i = 0; i < txtBrVrata.Text.Length; i++)
                {
                    bool jeste_cifra = txtBrVrata.Text.All(char.IsDigit);
                    if (jeste_cifra == false)
                    {
                        MessageBox.Show("Za broj vrata unesite samo cifre");
                        pogresanUnos++;
                        break;
                    }
                }
            }

            int greska = 0;
            if (praznaPolja == 0 && pogresanUnos == 0)
            {
                for (int i = 0; i < automobili.Count; i++)
                {
                    if (automobili[i].id == int.Parse(txtID.Text))
                    {
                        MessageBox.Show("Uneli ste postojeci ID.");
                        greska++;
                    }
                }
            }

            if (greska == 0 && praznaPolja == 0 && pogresanUnos == 0)
            {
                Automobil a = new Automobil(int.Parse(txtID.Text), int.Parse(txtGodiste.Text), int.Parse(txtKubikaza.Text),
                    txtMarka.Text, txtModel.Text, txtPogon.Text, txtMenjac.Text,
                    txtGorivo.Text, txtBrVrata.Text, txtKaroserija.Text);
                automobili.Add(a);
                upis_u_fajl_automobil();
                listAutaSvi.Items.Clear();
                IncijalizujListu();
                MessageBox.Show("Uspesno unet automobil.");

                listboxAutaPonuda.Items.Clear();
                inicijalizacija_spiska_auta();  /*listbox auta u odeljku ponuda*/

                txtID.Clear();
                txtMarka.Clear();
                txtModel.Clear();
                txtGodiste.Clear();
                txtBrVrata.Clear();
                txtKubikaza.Clear();
                txtKaroserija.Clear();
                txtPogon.Clear();
                txtMenjac.Clear();
                txtGorivo.Clear();
            }

        }

        private void BtnIzmeni_Click(object sender, EventArgs e)
        {
            citanje_iz_fajla_automobili();
            int selektovan;
            int greska = 0;

            if (listAutaSvi.SelectedItem == null)
            {
                MessageBox.Show("Niste selektovali automobil.");
                greska++;
            }

            if (greska == 0)
            {

                if (listAutaSvi.SelectedItem != listAutaSvi.Items[0])
                {
                    if (txtID.Text.Trim().Length == 0)
                    {
                        greska++;
                    }

                    if (txtGodiste.Text.Trim().Length == 0)
                    {
                        greska++;
                    }

                    if (txtMarka.Text.Trim().Length == 0)
                    {
                        greska++;

                    }

                    if (txtModel.Text.Trim().Length == 0)
                    {
                        greska++;
                    }

                    if (txtKubikaza.Text.Trim().Length == 0)
                    {
                        greska++;
                    }

                    if (txtPogon.Text.Trim().Length == 0)
                    {
                        greska++;
                    }

                    if (txtMenjac.Text.Trim().Length == 0)
                    {
                        greska++;
                    }

                    if (txtKaroserija.Text.Trim().Length == 0)
                    {
                        greska++;
                    }

                    if (txtGorivo.Text.Trim().Length == 0)
                    {
                        greska++;
                    }

                    if (txtBrVrata.Text.Trim().Length == 0)
                    {
                        greska++;
                    }

                    if (greska != 0)
                    {
                        MessageBox.Show("Popunite sva polja");
                    }
                    else
                    {
                        if (int.TryParse(txtID.Text, out int broj) == false)
                        {
                            MessageBox.Show("Za ID unesite samo cifre");
                            greska++;
                        }


                        if (int.TryParse(txtGodiste.Text, out broj) == false)
                        {
                            MessageBox.Show("Za godiste unesite samo cifre");
                            greska++;
                        }

                        if (int.TryParse(txtKubikaza.Text, out broj) == false)
                        {
                            MessageBox.Show("Za kubikazu unesite samo cifre");
                            greska++;
                        }

                        for (int i = 0; i < txtBrVrata.Text.Length; i++)
                        {
                            bool jeste_cifra = txtBrVrata.Text.All(char.IsDigit);
                            if (jeste_cifra == false)
                            {
                                MessageBox.Show("Za broj vrata unesite samo cifre");
                                greska++;
                                break;
                            }
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Niste selektovali automobil.");
                    greska++;
                }

                if (greska == 0)
                {
                    for (selektovan = 0; selektovan < automobili.Count; selektovan++)
                    {
                        if (automobili[selektovan].id == id_selektovanog_auta)
                        {
                            for (int i = 0; i < automobili.Count; i++)
                            {
                                if (selektovan != i)
                                {
                                    if (automobili[i].id == int.Parse(txtID.Text))
                                    {
                                        MessageBox.Show("Unesli ste postojeci ID.");
                                        greska++;
                                    }


                                }
                            }

                            if (greska == 0)
                            {
                                Automobil a = new Automobil(int.Parse(txtID.Text), int.Parse(txtGodiste.Text), int.Parse(txtKubikaza.Text),
                                txtMarka.Text, txtModel.Text, txtPogon.Text, txtMenjac.Text,
                                txtGorivo.Text, txtBrVrata.Text, txtKaroserija.Text);
                                automobili[selektovan] = a;
                                upis_u_fajl_automobil();
                                listAutaSvi.Items.Clear();
                                IncijalizujListu();
                                MessageBox.Show("Uspesno izmenjeni podaci o automobilu.");

                                listboxAutaPonuda.Items.Clear();
                                inicijalizacija_spiska_auta();  /*listbox auta u odeljku ponuda*/

                                txtID.Clear();
                                txtMarka.Clear();
                                txtModel.Clear();
                                txtGodiste.Clear();
                                txtBrVrata.Clear();
                                txtKubikaza.Clear();
                                txtKaroserija.Clear();
                                txtPogon.Clear();
                                txtMenjac.Clear();
                                txtGorivo.Clear();
                            }
                        }


                    }
                }


            }

        }

        private void ListAutaSvi_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listAutaSvi.SelectedItem != listAutaSvi.Items[0])
            {
                citanje_iz_fajla_automobili();
                string[] id_auta = listAutaSvi.SelectedItem.ToString().Split(' ');

                for (int i = 0; i < automobili.Count; i++)
                {
                    if (id_auta[1] == automobili[i].id.ToString())
                    {
                        txtID.Text = automobili[i].id.ToString();
                        id_selektovanog_auta = int.Parse(txtID.Text);

                        txtMarka.Text = automobili[i].marka;
                        txtModel.Text = automobili[i].model;
                        txtGodiste.Text = automobili[i].godiste.ToString();
                        txtBrVrata.Text = automobili[i].brVrata;
                        txtKubikaza.Text = automobili[i].kubikaza.ToString();
                        txtKaroserija.Text = automobili[i].karoserija;
                        txtPogon.Text = automobili[i].pogon;
                        txtMenjac.Text = automobili[i].menjac;
                        txtGorivo.Text = automobili[i].gorivo;

                    }
                }
            }
            else
            {
                txtID.Clear();
                txtMarka.Clear();
                txtModel.Clear();
                txtGodiste.Clear();
                txtBrVrata.Clear();
                txtKubikaza.Clear();
                txtKaroserija.Clear();
                txtPogon.Clear();
                txtMenjac.Clear();
                txtGorivo.Clear();
            }
        }

        private void BtnObrisi_Click(object sender, EventArgs e)
        {
            int greska = 0;
            if (listAutaSvi.SelectedItem == null)
            {
                MessageBox.Show("Niste selektovali automobil.");
                greska++;
            }

            if (greska == 0)
            {
                if (listAutaSvi.SelectedItem != listAutaSvi.Items[0])
                {
                    string[] selektovani = listAutaSvi.SelectedItem.ToString().Split(' ');
                    for (int i = 0; i < automobili.Count; i++)
                    {
                        if (automobili[i].id.ToString() == selektovani[1])
                        {
                            citanje_iz_fajla_rezervacije();
                            for (int j = 0; j < rezervacije.Count; j++)
                            {
                                if (automobili[i].id == rezervacije[j].getIDauta())
                                {
                                    rezervacije.RemoveAt(j);

                                    BinaryFormatter bff = new BinaryFormatter();
                                    FileStream fss = File.OpenWrite(fajl_rezervacije);
                                    bff.Serialize(fss, rezervacije);
                                    fss.Dispose();
                                }
                            }

                            citanje_iz_fajla_ponuda();
                            for (int j = 0; j < ponuda.Count; j++)
                            {
                                if (automobili[i].id == ponuda[j].ID)
                                {
                                    ponuda.RemoveAt(j);
                                    upis_u_fajl_ponuda();
                                }
                            }

                            automobili.RemoveAt(i);
                            listAutaSvi.Items.Clear();
                            upis_u_fajl_automobil();
                            IncijalizujListu();
                            listboxAutaPonuda.Items.Clear();
                            inicijalizacija_spiska_auta();  /*listbox auta u odeljku ponuda*/

                            MessageBox.Show("Uspesno obrisan automobil iz spiska.");

                            txtID.Clear();
                            txtMarka.Clear();
                            txtModel.Clear();
                            txtGodiste.Clear();
                            txtBrVrata.Clear();
                            txtKubikaza.Clear();
                            txtKaroserija.Clear();
                            txtPogon.Clear();
                            txtMenjac.Clear();
                            txtGorivo.Clear();

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Niste selektovali automobil.");
                }
            }




        }

        /************                  KOD ZA KUPCA                       ***********/




        List<Kupac> kupci;
        string fajl;
        int id_selektovanog_kupca;
        int greska_selektovanja;

        private void upis_u_fajl_kupac()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = File.OpenWrite(fajl);
            bf.Serialize(fs, kupci);
            MessageBox.Show("Uspesno dodat kupac.");
            fs.Dispose();

            txtIDkupca.Clear();
            txtImekupca.Clear();
            txtJmbg.Clear();
            txtPrezimekupca.Clear();
            txtTelefonkupca.Clear();
        }

        private void citanje_iz_fajla_kupac()
        {
            if (File.Exists(fajl))
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = File.OpenRead(fajl);
                kupci = bf.Deserialize(fs) as List<Kupac>;
                fs.Dispose();
            }
        }

        private void dodaj_u_listboxKupac()
        {
            listKupci.Items.Clear();
            listKupci.Items.Add("Nijedan od ponudjenih");
            if (File.Exists(fajl))
            {
                List<Kupac> sviKupci = new List<Kupac>();
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = File.OpenRead(fajl);
                sviKupci = bf.Deserialize(fs) as List<Kupac>;
                for (int i = 0; i < sviKupci.Count; i++)
                {
                    listKupci.Items.Add(sviKupci[i]);
                }
                fs.Dispose();
            }
        }



        private void BtnUnesiKupca_Click(object sender, EventArgs e)
        {
            citanje_iz_fajla_kupac();
            /* provere unosa  */
            int prazno_polje = 0;
            int unos_cifara = 0;
            int id;


            if (txtIDkupca.Text.Trim().Length == 0)
            {
                prazno_polje++;
            }

            if (txtImekupca.Text.Trim().Length == 0)
            {
                prazno_polje++;
            }

            if (txtPrezimekupca.Text.Trim().Length == 0)
            {
                prazno_polje++;
            }

            if (txtJmbg.Text.Trim().Length == 0)
            {
                prazno_polje++;
            }

            if (txtTelefonkupca.Text.Trim().Length == 0)
            {
                prazno_polje++;
            }

            if (prazno_polje != 0)
            {
                MessageBox.Show("Popunite sva polja");
            }
            else
            {

                if (int.TryParse(txtIDkupca.Text, out id) == false)
                {
                    MessageBox.Show("Za polje ID unesite samo cifre");
                    unos_cifara++;
                }

                for (int i = 0; i < txtJmbg.Text.Length; i++)
                {
                    bool jeste_cifra = txtJmbg.Text.All(char.IsDigit);
                    if (jeste_cifra == false)
                    {
                        MessageBox.Show("Za polje JMBG unesite samo cifre");
                        unos_cifara++;
                        break;
                    }
                }

                for (int i = 0; i < txtTelefonkupca.Text.Length; i++)
                {
                    bool jeste_cifra = txtTelefonkupca.Text.All(char.IsDigit);
                    if (jeste_cifra == false)
                    {
                        MessageBox.Show("Za polje Telefon unesite samo cifre");
                        unos_cifara++;
                        break;
                    }
                }

                int greska = 0;
                if (prazno_polje == 0 && unos_cifara == 0)
                {
                    for (int i = 0; i < kupci.Count; i++)
                    {
                        if (kupci[i].getID() == int.Parse(txtIDkupca.Text))
                        {
                            MessageBox.Show("Unesli ste postojeci ID.");
                            greska++;
                        }

                        if (kupci[i].getJmbg() == txtJmbg.Text)
                        {
                            MessageBox.Show("Unesli ste postojeci JMBG.");
                            greska++;
                        }

                        if (kupci[i].getTelefon() == txtTelefonkupca.Text)
                        {
                            MessageBox.Show("Unesli ste postojeci broj telefona.");
                            greska++;
                        }
                    }
                }

                /* upis u fajl "kupci" */
                if (greska == 0)
                {
                    id = int.Parse(txtIDkupca.Text);
                    string korisnickoIme = "kupac" + id.ToString();
                    string lozinka = korisnickoIme;
                    Kupac k = new Kupac(int.Parse(txtIDkupca.Text), korisnickoIme, lozinka,
                                        txtImekupca.Text, txtPrezimekupca.Text,
                                        txtTelefonkupca.Text, txtJmbg.Text,
                                        dateTimeDatRodjKupca.Value);
                    kupci.Add(k);
                    upis_u_fajl_kupac();

                    inicijalizacija_kupaca();
                    dodaj_u_listboxKupac();




                }


            }
        }

        private void BtnIzmeniKupca_Click(object sender, EventArgs e)
        {
            citanje_iz_fajla_kupac();
            int selektovan;
            int greska = 0;

            if (greska_selektovanja != 0)
            {
                MessageBox.Show("Niste selektovali kupca.");
            }


            if (listKupci.SelectedItem == listKupci.Items[0])
            {
                MessageBox.Show("Niste selektovali kupca.");
                greska_selektovanja++;
            }


            if (greska_selektovanja == 0)
            {
                if (txtIDkupca.Text.Trim().Length == 0)
                {
                    greska++;
                }

                if (txtImekupca.Text.Trim().Length == 0)
                {
                    greska++;
                }

                if (txtPrezimekupca.Text.Trim().Length == 0)
                {
                    greska++;
                }

                if (txtJmbg.Text.Trim().Length == 0)
                {
                    greska++;
                }

                if (txtTelefonkupca.Text.Trim().Length == 0)
                {
                    greska++;
                }

                if (greska != 0)
                {
                    MessageBox.Show("Popunite sva polja");
                }
                else
                {

                    if (int.TryParse(txtIDkupca.Text, out int id) == false)
                    {
                        MessageBox.Show("Za polje ID unesite samo cifre");
                        greska++;
                    }

                    for (int i = 0; i < txtJmbg.Text.Length; i++)
                    {
                        bool jeste_cifra = txtJmbg.Text.All(char.IsDigit);
                        if (jeste_cifra == false)
                        {
                            MessageBox.Show("Za polje JMBG unesite samo cifre");
                            greska++;
                            break;
                        }
                    }

                    for (int i = 0; i < txtTelefonkupca.Text.Length; i++)
                    {
                        bool jeste_cifra = txtTelefonkupca.Text.All(char.IsDigit);
                        if (jeste_cifra == false)
                        {
                            MessageBox.Show("Za polje Telefon unesite samo cifre");
                            greska++;
                            break;
                        }
                    }
                }
            }




            if (greska == 0 && greska_selektovanja == 0)
            {
                for (selektovan = 0; selektovan < kupci.Count; selektovan++)
                {
                    if (kupci[selektovan].getID() == id_selektovanog_kupca)
                    {
                        for (int i = 0; i < kupci.Count; i++)
                        {
                            if (selektovan != i)
                            {
                                if (kupci[i].getID() == int.Parse(txtIDkupca.Text))
                                {
                                    MessageBox.Show("Unesli ste postojeci ID.");
                                    greska++;
                                }

                                if (kupci[i].getJmbg() == txtJmbg.Text)
                                {
                                    MessageBox.Show("Unesli ste postojeci JMBG.");
                                    greska++;
                                }

                                if (kupci[i].getTelefon() == txtTelefonkupca.Text)
                                {
                                    MessageBox.Show("Unesli ste postojeci broj telefona.");
                                    greska++;
                                }
                            }
                        }

                        if (greska == 0)
                        {
                            string korisnickoIme = "kupac" + int.Parse(txtIDkupca.Text).ToString();
                            string lozinka = korisnickoIme;
                            Kupac k = new Kupac(int.Parse(txtIDkupca.Text), korisnickoIme, lozinka,
                                                txtImekupca.Text, txtPrezimekupca.Text,
                                                txtTelefonkupca.Text, txtJmbg.Text,
                                                dateTimeDatRodjKupca.Value);

                            kupci[selektovan] = k;

                            BinaryFormatter bf = new BinaryFormatter();
                            FileStream fs = File.OpenWrite(fajl);
                            bf.Serialize(fs, kupci);
                            MessageBox.Show("Uspesno izmenjeni podaci o kupcu.");
                            fs.Dispose();

                            txtIDkupca.Clear();
                            txtImekupca.Clear();
                            txtJmbg.Clear();
                            txtPrezimekupca.Clear();
                            txtTelefonkupca.Clear();
                            dateTimeDatRodjKupca.Value = DateTime.Now;

                            inicijalizacija_kupaca();
                            dodaj_u_listboxKupac();

                        }
                    }


                }
            }

        }

        private void ListKupci_SelectedValueChanged(object sender, EventArgs e)
        {

            citanje_iz_fajla_kupac();
            greska_selektovanja = 0;

            if (listKupci.SelectedItem != listKupci.Items[0])
            {
                foreach (Kupac kupac in kupci)
                {
                    int id;
                    string[] rec = listKupci.SelectedItem.ToString().Split(' ');
                    id = int.Parse(rec[0]);

                    if (kupac.getID() == id)
                    {
                        txtIDkupca.Text = kupac.getID().ToString();

                        id_selektovanog_kupca = int.Parse(txtIDkupca.Text);

                        txtImekupca.Text = kupac.getIme();
                        txtPrezimekupca.Text = kupac.getPrezime();
                        txtJmbg.Text = kupac.getJmbg();
                        txtTelefonkupca.Text = kupac.getTelefon();
                        dateTimeDatRodjKupca.Value = kupac.getDatumRodjenja();
                        break;
                    }
                }
            }
            else
            {
                txtIDkupca.Clear();
                txtImekupca.Clear();
                txtJmbg.Clear();
                txtPrezimekupca.Clear();
                txtTelefonkupca.Clear();
                dateTimeDatRodjKupca.Value = DateTime.Now;
                id_selektovanog_kupca = -1111;
            }



        }

        private void BtnObrisiKupca_Click(object sender, EventArgs e)
        {
            if (listKupci.SelectedItem != null)
            {
                string[] selektovani = listKupci.SelectedItem.ToString().Split(' ');

                citanje_iz_fajla_kupac();
                if (greska_selektovanja == 0)
                {
                    if (listKupci.SelectedItem != listKupci.Items[0])
                    {
                        for (int i = 0; i < kupci.Count; i++)
                        {
                            if (kupci[i].getID().ToString() == selektovani[0])
                            {
                                citanje_iz_fajla_rezervacije();
                                for (int j = 0; j < rezervacije.Count; j++)
                                {
                                    if (kupci[i].getID() == rezervacije[j].getIDkupca())
                                    {
                                        rezervacije.RemoveAt(j);

                                        BinaryFormatter bff = new BinaryFormatter();
                                        FileStream fss = File.OpenWrite(fajl_rezervacije);
                                        bff.Serialize(fss, rezervacije);
                                        fss.Dispose();
                                    }
                                }

                                kupci.RemoveAt(i);

                                BinaryFormatter bf = new BinaryFormatter();
                                FileStream fs = File.OpenWrite(fajl);
                                bf.Serialize(fs, kupci);
                                MessageBox.Show("Uspesno obrisan kupac.");
                                fs.Dispose();

                                txtIDkupca.Clear();
                                txtImekupca.Clear();
                                txtJmbg.Clear();
                                txtPrezimekupca.Clear();
                                txtTelefonkupca.Clear();
                                dateTimeDatRodjKupca.Value = DateTime.Now;

                                inicijalizacija_kupaca();
                                dodaj_u_listboxKupac();



                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Niste selektovali kupca.");
                    }
                }
                else
                {
                    MessageBox.Show("Niste selektovali kupca.");
                }
            }
            else
            {
                MessageBox.Show("Niste selektovali kupca u listi.");
            }


        }

        /***********                      PONUDA                 ********/

        List<Ponuda> ponuda;
        string fajl_ponuda;
        int greska_selektovanja_auta_ponuda;


        private void upis_u_fajl_ponuda()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = File.OpenWrite(fajl_ponuda);
            bf.Serialize(fs, ponuda);
            fs.Dispose();
        }
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

        private void inicijalizacija_spiska_auta()
        {
            citanje_iz_fajla_automobili();
            listboxAutaPonuda.Items.Add("Nijedan od ponudjenih");
            for (int i = 0; i < automobili.Count; i++)
            {
                listboxAutaPonuda.Items.Add(automobili[i].id + " " + automobili[i].marka + " " +
                    automobili[i].model + " " + "  Godiste: " + automobili[i].godiste);
            }


        }

        private void inicijalizacija_ponude()
        {
            citanje_iz_fajla_automobili();
            citanje_iz_fajla_ponuda();
            string[] selektovani = listboxAutaPonuda.SelectedItem.ToString().Split(' ');
            for (int i = 0; i < automobili.Count; i++)
            {
                if (automobili[i].id == int.Parse(selektovani[0]))
                {
                    txtBrVrPonuda.Text = automobili[i].brVrata;
                    txtIdPonuda.Text = automobili[i].id.ToString();
                    txtKaroPonuda.Text = automobili[i].karoserija;
                    txtKubPonuda.Text = automobili[i].kubikaza.ToString();
                    txtMenjacPonuda.Text = automobili[i].menjac;
                    txtModelPonuda.Text = automobili[i].model;
                    txtPogonPonuda.Text = automobili[i].pogon;
                    txtMarkaPonuda.Text = automobili[i].marka;
                    txtGodPonuda.Text = automobili[i].godiste.ToString();
                    txtGorivoPonuda.Text = automobili[i].gorivo;

                }
            }

            for (int j = 0; j < ponuda.Count; j++)
            {
                if (ponuda[j].ID == int.Parse(selektovani[0]))
                {
                    listboxPonudaZaAuto.Items.Add(ponuda[j].getDatumOd().ToShortDateString() +
                        " - " + ponuda[j].getDatumDo().ToShortDateString() + " " +
                        "Cena po danu:" + " " + ponuda[j].Cena);
                }
            }
        }
        private void ListboxAutaPonuda_SelectedValueChanged(object sender, EventArgs e)
        {
            listboxPonudaZaAuto.Items.Clear();
            greska_selektovanja_auta_ponuda = 0;

            int greska = 0;

            if (listboxAutaPonuda.SelectedItem == listboxAutaPonuda.Items[0])
            {
                listboxPonudaZaAuto.Items.Clear();
                txtBrVrPonuda.Clear();
                txtIdPonuda.Clear();
                txtKaroPonuda.Clear();
                txtKubPonuda.Clear();
                txtMenjacPonuda.Clear();
                txtModelPonuda.Clear();
                txtPogonPonuda.Clear();
                txtMarkaPonuda.Clear();
                txtGodPonuda.Clear();
                txtGorivoPonuda.Clear();
                dateTimeOD.Value = DateTime.Now;
                dateTimeDO.Value = DateTime.Now;
                txtCenaPoDanu.Clear();
                greska++;
            }

            if (greska == 0)
            {
                inicijalizacija_ponude();
            }

        }

        private void BtnUnesiPonudu_Click(object sender, EventArgs e)
        {
            int greska = 0;
            if (greska_selektovanja_auta_ponuda != 0)
            {
                MessageBox.Show("Niste selektovali automobil.");
            }

            if (listboxAutaPonuda.SelectedItem == listboxAutaPonuda.Items[0])
            {
                MessageBox.Show("Niste selektovali automobil.");
                greska++;
            }
            else
            {
                int prazno_polje = 0;
                if (txtCenaPoDanu.Text == "")
                {
                    MessageBox.Show("Popunite polje cena po danu.");
                    prazno_polje++;
                    greska++;
                }

                if (prazno_polje == 0)
                {
                    if (!int.TryParse(txtCenaPoDanu.Text, out int cena))
                    {
                        MessageBox.Show("Za cenu po danu unesite samo cifre.");
                        greska++;
                    }
                }


                if (dateTimeOD.Value.Date > dateTimeDO.Value.Date)
                {
                    MessageBox.Show("Unesite ispravan opseg datuma.");
                    greska++;
                }
            }



            if (greska_selektovanja_auta_ponuda == 0 && greska == 0)
            {
                citanje_iz_fajla_ponuda();
                for (int i = 0; i < ponuda.Count; i++)
                {
                    if (int.Parse(txtIdPonuda.Text) == ponuda[i].ID &&
                        dateTimeOD.Value.Date >= ponuda[i].getDatumOd().Date &&
                        dateTimeOD.Value.Date <= ponuda[i].getDatumDo().Date)
                    {
                        MessageBox.Show("Uneli ste postojeci termin u ponudi!");
                        greska++;
                        break;
                    }

                    if (int.Parse(txtIdPonuda.Text) == ponuda[i].ID &&
                        dateTimeDO.Value.Date >= ponuda[i].getDatumOd().Date &&
                        dateTimeDO.Value.Date <= ponuda[i].getDatumDo().Date)
                    {
                        MessageBox.Show("Uneli ste postojeci termin u ponudi!");
                        greska++;
                        break;
                    }

                    if (int.Parse(txtIdPonuda.Text) == ponuda[i].ID &&
                        dateTimeOD.Value.Date >= ponuda[i].getDatumOd().Date &&
                        dateTimeDO.Value.Date <= ponuda[i].getDatumDo().Date)
                    {
                        MessageBox.Show("Uneli ste postojeci termin u ponudi!");
                        greska++;
                        break;
                    }

                    if (int.Parse(txtIdPonuda.Text) == ponuda[i].ID &&
                        dateTimeOD.Value.Date <= ponuda[i].getDatumOd().Date &&
                        dateTimeDO.Value.Date >= ponuda[i].getDatumDo().Date)
                    {
                        MessageBox.Show("Uneli ste postojeci termin u ponudi!");
                        greska++;
                        break;
                    }
                }
            }

            if (greska == 0)
            {
                Ponuda p = new Ponuda(int.Parse(txtIdPonuda.Text), int.Parse(txtCenaPoDanu.Text),
                            dateTimeOD.Value.Date, dateTimeDO.Value.Date);
                ponuda.Add(p);
                upis_u_fajl_ponuda();
                MessageBox.Show("Uspesno uneta ponuda.");
                listboxPonudaZaAuto.Items.Clear();
                inicijalizacija_ponude();
            }

        }

        private void BtnObrisiPonudu_Click(object sender, EventArgs e)
        {


            if (listboxPonudaZaAuto.SelectedItem == null)
            {
                MessageBox.Show("Niste selektovali ponudu za auto.");
            }
            else
            {
                string[] selektovani = listboxPonudaZaAuto.SelectedItem.ToString().Split(' ');
                citanje_iz_fajla_ponuda();

                for (int i = 0; i < ponuda.Count; i++)
                {
                    if (int.Parse(txtIdPonuda.Text) == ponuda[i].ID &&
                        selektovani[0] == ponuda[i].getDatumOd().ToShortDateString() &&
                        selektovani[2] == ponuda[i].getDatumDo().ToShortDateString()
                        )
                    {
                        ponuda.RemoveAt(i);
                        upis_u_fajl_ponuda();
                        MessageBox.Show("Uspesno izbrisana ponuda.");
                        listboxPonudaZaAuto.Items.Clear();
                        inicijalizacija_ponude();
                    }
                }
            }

        }

        /*****              Kod za rezervacije           *******/

        List<Rezervacije> rezervacije;
        string fajl_rezervacije;
        private void inicijalizacija_kupaca()
        {
            citanje_iz_fajla_kupac();
            comboboxKupaca.Items.Clear();
            comboboxKupaca.Items.Add("Ponisti odabrano");
            for (int i = 0; i < kupci.Count; i++)
            {
                comboboxKupaca.Items.Add(kupci[i].getID() + " " + kupci[i].getIme() + " " + kupci[i].getPrezime());
            }
        }

        private void upis_u_fajl_rezervacije()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = File.OpenWrite(fajl_rezervacije);
            bf.Serialize(fs, rezervacije);
            MessageBox.Show("Uspesno uklonjena rezervacija.");
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
        private void inicijalizacija_rezervacija()
        {
            citanje_iz_fajla_rezervacije();
            if (comboboxKupaca.SelectedItem == comboboxKupaca.Items[0])
            {
                listboxRezervacije.Items.Clear();
                txtIDkupcaRez.Clear();
                txtIDautaRez.Clear();
                txtDatPreuzimanje.Clear();
                txtDatVracanje.Clear(); ;
                txtCena.Clear();
            }
            else
            {
                listboxRezervacije.Items.Clear();
                string[] id_kupca = comboboxKupaca.SelectedItem.ToString().Split(' ');
                listboxRezervacije.Items.Add("Ponisti odabrano");
                for (int j = 0; j < rezervacije.Count; j++)
                {
                    if (rezervacije[j].getIDkupca() == int.Parse(id_kupca[0]))
                    {
                        for (int z = 0; z < automobili.Count; z++)
                        {
                            if (rezervacije[j].getIDauta() == automobili[z].id)
                            {
                                listboxRezervacije.Items.Add(automobili[z].id + " " +
                                    automobili[z].marka + " " +
                                    automobili[z].model + " " +
                                    rezervacije[j].getDatumOd().ToShortDateString() + " - " +
                                    rezervacije[j].getDatumDO().ToShortDateString());
                            }
                        }
                    }
                }
            }

        }

        private void ComboboxKupaca_SelectedValueChanged(object sender, EventArgs e)
        {
            inicijalizacija_rezervacija();
        }



        private void ListboxRezervacije_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listboxRezervacije.SelectedItem == listboxRezervacije.Items[0])
            {
                txtIDkupcaRez.Clear();
                txtIDautaRez.Clear();
                txtDatPreuzimanje.Clear();
                txtDatVracanje.Clear(); ;
                txtCena.Clear();
            }
            else
            {
                string[] selektovana_rez = listboxRezervacije.SelectedItem.ToString().Split(' ');
                int id_auta = int.Parse(selektovana_rez[0]);



                citanje_iz_fajla_rezervacije();

                for (int i = 0; i < rezervacije.Count; i++)
                {
                    if (id_auta == rezervacije[i].getIDauta() &&
                        selektovana_rez[3] == rezervacije[i].getDatumOd().ToShortDateString() &&
                        selektovana_rez[5] == rezervacije[i].getDatumDO().ToShortDateString()
                        )
                    {
                        txtIDkupcaRez.Text = rezervacije[i].getIDkupca().ToString();
                        txtIDautaRez.Text = rezervacije[i].getIDauta().ToString();
                        txtDatPreuzimanje.Text = rezervacije[i].getDatumOd().ToShortDateString();
                        txtDatVracanje.Text = rezervacije[i].getDatumDO().ToShortDateString();
                        txtCena.Text = rezervacije[i].getCena().ToString();
                    }
                }
            }




        }



        /**************              Kod za statistiku              ********/

        
        private static float parce = 0;
       

        private void inicijalizuj_format_vremena()
        {
            dateTimeMesec.CustomFormat = "MMMM yyyy";
            dateTimeMesec.ShowUpDown = true;

            
        }

        private void inicijalizuj_komboboks_Marka1()
        {
            citanje_iz_fajla_automobili();
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
            cmbMarka.Items.Add("Ponisti odabrano");
            for (int i = 0; i < markeSkraceno.Count; i++)
            {
                cmbMarka.Items.Add(markeSkraceno[i]);
            }



           


        }
            
        private void crtanje(object sender, PaintEventArgs e)
        {
            Rectangle  r = new Rectangle(38, 300, 150, 150);
            e.Graphics.DrawEllipse(Pens.Black, r);
            e.Graphics.FillEllipse(Brushes.Blue, r);
            if (parce == 0)
            {
                e.Graphics.FillPie(Brushes.Red, r, -90F, parce);
            }
            else
            {
                e.Graphics.FillPie(Brushes.Yellow, r, -90F, parce);
            }
            

        }

        private void crtanje2(object sender, PaintEventArgs e)
        {
            Rectangle r = new Rectangle(38, 300, 150, 150);
            e.Graphics.DrawEllipse(Pens.SeaShell, r);
            e.Graphics.FillEllipse(Brushes.SeaShell, r);
            e.Graphics.FillEllipse(Brushes.SeaShell, r);
            
        }
        private void BtnPrikaziStat_Click(object sender, EventArgs e)
        {
            citanje_iz_fajla_rezervacije();
            List<int> rentirana_kola = new List<int>();
            int greska = 0;
            if (cmbMarka.SelectedItem == null)
            {
                MessageBox.Show("Niste selektovali marku.");
                greska++;

            }

            if (cmbMarka.SelectedIndex == 0 && greska == 0)
            {
                MessageBox.Show("Niste selektovali marku.");
                greska++;                
            }
                        
                                              
            int broj = 0;
            float procenat;
           
            if (greska == 0)
            {

                for (int i = 0; i < rezervacije.Count; i++)
                {
                    if (rezervacije[i].getDatumDO().Year== dateTimeMesec.Value.Year &&
                        rezervacije[i].getDatumDO().Month == dateTimeMesec.Value.Month)
                    {
                        rentirana_kola.Add(rezervacije[i].getIDauta());
                    }                                                               
                }

                IEnumerable<int> id_auta = rentirana_kola.Distinct();

                if (id_auta.Count() == 0)
                {
                    procenat = broj;
                    txtUkupno.Text = id_auta.Count().ToString();
                    txtUkupnoMarka.Text = broj.ToString();
                    txtProcenatMarka.Text = procenat.ToString() +"%";

                    parce = procenat * 3.6F;
                    this.tabPage5.Paint += crtanje;
                    this.Invalidate();
                }
                else
                {

                   

                    for (int i = 0; i < id_auta.Count(); i++)
                    {
                        for (int j = 0; j < automobili.Count; j++)
                        {
                            if (id_auta.ToList()[i]==(automobili[j].id))
                            {
                                if (automobili[j].marka == (string)cmbMarka.SelectedItem)
                                {
                                    broj++;
                                    break;
                                }                                                                    
                            }
                        }
                    }
                    procenat = (float)broj / id_auta.Count() * 100;

                    txtUkupno.Text = id_auta.Count().ToString();
                    txtUkupnoMarka.Text = broj.ToString();
                    txtProcenatMarka.Text = (Math.Round(procenat)).ToString() + "%";

                    parce = procenat * 3.6F;
                    this.tabPage5.Paint += crtanje;
                    this.Invalidate();
                }

              
            }
           
        }

        private void CmbMarka_SelectedValueChanged(object sender, EventArgs e)
        {
            txtUkupno.Clear();
            txtUkupnoMarka.Clear();
            txtProcenatMarka.Clear();
            this.tabPage5.Paint += crtanje2;
            this.Invalidate();
        }
    }
}