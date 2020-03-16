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
    public partial class Form1 : Form
    {
        Administrator admin;
        List<Kupac> kupci;

        string fajl_kupac;
        string fajl_lozinka;
        public Form1()
        {
            InitializeComponent();
            InicijalizujLozinku();
            InicijalizujAdmin();

            kupci = new List<Kupac>();
            fajl_kupac = "kupci.bin";
            fajl_lozinka = "lozinka.txt";
        }


        private void InicijalizujLozinku()
        {                                   
            txtLozinka.PasswordChar = '*';                        
        }

        private void InicijalizujAdmin()
        {
            DateTime datumRodj = new DateTime(1994, 8, 19, 8,19,8,5);
            admin = new Administrator(1, "admin", "admin","Vladimir", "Lazic","01234567","1908994773629",datumRodj);
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

        private void inicijalizujLogIn()
        {
            txtKorisnickoIme.Clear();
            txtLozinka.Clear();
        }
        private void BtnPrijava_Click(object sender, EventArgs e)
        {
            if (radiobtnAdmin.Checked)
            {                
                if (txtKorisnickoIme.Text == admin.KorisnickoIme && txtLozinka.Text == admin.Lozinka)
                {
                    FrmAdministracija formaAdmin = new FrmAdministracija();
                    formaAdmin.Show();
                    
                }
                else
                {
                    MessageBox.Show("Pogresno uneti podaci");
                }
            }
            else if(radiobtnKupac.Checked)
            {
                int greska = 0;
                citanje_iz_fajla_kupac();
                for (int i = 0; i < kupci.Count; i++)
                {
                    if (kupci[i].getKorisnickoIme() == txtKorisnickoIme.Text &&
                        kupci[i].getLozinka() == txtLozinka.Text)
                    {
                        File.WriteAllText(fajl_lozinka, txtLozinka.Text);
                        Moje_Rezervacije frmMojeRezervacije = new Moje_Rezervacije();
                        frmMojeRezervacije.Show();                        
                        break;                       
                    }
                    else
                    {
                        greska++;
                    }
                }

                if (greska != 0)
                {
                    MessageBox.Show("Pogresno uneti podaci");
                }

            }
           
        }

        private void RadiobtnAdmin_CheckedChanged(object sender, EventArgs e)
        {
            inicijalizujLogIn();
        }

        private void RadiobtnKupac_CheckedChanged(object sender, EventArgs e)
        {
            inicijalizujLogIn();
        }
    }
}
