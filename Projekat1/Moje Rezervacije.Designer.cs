namespace Projekat1
{
    partial class Moje_Rezervacije
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listboxRezervacije = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtImeKupca = new System.Windows.Forms.TextBox();
            this.txtPrezimeKupca = new System.Windows.Forms.TextBox();
            this.txtJMBG = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtDatRodjenja = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtKubikaza = new System.Windows.Forms.TextBox();
            this.txtGorivo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtKaroserija = new System.Windows.Forms.TextBox();
            this.txtPogon = new System.Windows.Forms.TextBox();
            this.txtGodiste = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtBrVrata = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtMenjac = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtDatPreuzimanje = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtDatVracanje = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.btnUkini = new System.Windows.Forms.Button();
            this.btnNovaRez = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listboxRezervacije
            // 
            this.listboxRezervacije.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listboxRezervacije.FormattingEnabled = true;
            this.listboxRezervacije.ItemHeight = 16;
            this.listboxRezervacije.Location = new System.Drawing.Point(308, 45);
            this.listboxRezervacije.Margin = new System.Windows.Forms.Padding(4);
            this.listboxRezervacije.Name = "listboxRezervacije";
            this.listboxRezervacije.Size = new System.Drawing.Size(513, 244);
            this.listboxRezervacije.TabIndex = 0;
            this.listboxRezervacije.SelectedValueChanged += new System.EventHandler(this.ListboxRezervacije_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prezime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "JMBG:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Telefon:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Datum Rodjenja:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(68, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Podaci o korisniku:";
            // 
            // txtImeKupca
            // 
            this.txtImeKupca.Location = new System.Drawing.Point(71, 72);
            this.txtImeKupca.Name = "txtImeKupca";
            this.txtImeKupca.ReadOnly = true;
            this.txtImeKupca.Size = new System.Drawing.Size(182, 22);
            this.txtImeKupca.TabIndex = 7;
            // 
            // txtPrezimeKupca
            // 
            this.txtPrezimeKupca.Location = new System.Drawing.Point(74, 128);
            this.txtPrezimeKupca.Name = "txtPrezimeKupca";
            this.txtPrezimeKupca.ReadOnly = true;
            this.txtPrezimeKupca.Size = new System.Drawing.Size(182, 22);
            this.txtPrezimeKupca.TabIndex = 8;
            // 
            // txtJMBG
            // 
            this.txtJMBG.Location = new System.Drawing.Point(74, 181);
            this.txtJMBG.Name = "txtJMBG";
            this.txtJMBG.ReadOnly = true;
            this.txtJMBG.Size = new System.Drawing.Size(182, 22);
            this.txtJMBG.TabIndex = 9;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(74, 225);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.ReadOnly = true;
            this.txtTelefon.Size = new System.Drawing.Size(182, 22);
            this.txtTelefon.TabIndex = 10;
            // 
            // txtDatRodjenja
            // 
            this.txtDatRodjenja.Location = new System.Drawing.Point(74, 278);
            this.txtDatRodjenja.Name = "txtDatRodjenja";
            this.txtDatRodjenja.ReadOnly = true;
            this.txtDatRodjenja.Size = new System.Drawing.Size(182, 22);
            this.txtDatRodjenja.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(305, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Moje rezervacije:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(74, 324);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(251, 32);
            this.label8.TabIndex = 14;
            this.label8.Text = "Podaci o rezervisanom automobilu:\r\n\r\n";
            // 
            // txtMarka
            // 
            this.txtMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarka.Location = new System.Drawing.Point(75, 359);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.ReadOnly = true;
            this.txtMarka.Size = new System.Drawing.Size(182, 22);
            this.txtMarka.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(74, 340);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Marka:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(360, 340);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "Kubikaza:";
            // 
            // txtKubikaza
            // 
            this.txtKubikaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKubikaza.Location = new System.Drawing.Point(363, 359);
            this.txtKubikaza.Name = "txtKubikaza";
            this.txtKubikaza.ReadOnly = true;
            this.txtKubikaza.Size = new System.Drawing.Size(182, 22);
            this.txtKubikaza.TabIndex = 18;
            // 
            // txtGorivo
            // 
            this.txtGorivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGorivo.Location = new System.Drawing.Point(622, 359);
            this.txtGorivo.Name = "txtGorivo";
            this.txtGorivo.ReadOnly = true;
            this.txtGorivo.Size = new System.Drawing.Size(182, 22);
            this.txtGorivo.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(619, 340);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "Gorivo:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(74, 393);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 16);
            this.label12.TabIndex = 21;
            this.label12.Text = "Model:";
            // 
            // txtModel
            // 
            this.txtModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModel.Location = new System.Drawing.Point(77, 412);
            this.txtModel.Name = "txtModel";
            this.txtModel.ReadOnly = true;
            this.txtModel.Size = new System.Drawing.Size(182, 22);
            this.txtModel.TabIndex = 22;
            // 
            // txtKaroserija
            // 
            this.txtKaroserija.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKaroserija.Location = new System.Drawing.Point(363, 412);
            this.txtKaroserija.Name = "txtKaroserija";
            this.txtKaroserija.ReadOnly = true;
            this.txtKaroserija.Size = new System.Drawing.Size(182, 22);
            this.txtKaroserija.TabIndex = 23;
            // 
            // txtPogon
            // 
            this.txtPogon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPogon.Location = new System.Drawing.Point(622, 412);
            this.txtPogon.Name = "txtPogon";
            this.txtPogon.ReadOnly = true;
            this.txtPogon.Size = new System.Drawing.Size(182, 22);
            this.txtPogon.TabIndex = 24;
            // 
            // txtGodiste
            // 
            this.txtGodiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGodiste.Location = new System.Drawing.Point(75, 465);
            this.txtGodiste.Name = "txtGodiste";
            this.txtGodiste.ReadOnly = true;
            this.txtGodiste.Size = new System.Drawing.Size(182, 22);
            this.txtGodiste.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(360, 393);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 16);
            this.label13.TabIndex = 26;
            this.label13.Text = "Karoserija:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(619, 393);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 16);
            this.label14.TabIndex = 27;
            this.label14.Text = "Pogon:";
            // 
            // txtBrVrata
            // 
            this.txtBrVrata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrVrata.Location = new System.Drawing.Point(361, 465);
            this.txtBrVrata.Name = "txtBrVrata";
            this.txtBrVrata.ReadOnly = true;
            this.txtBrVrata.Size = new System.Drawing.Size(182, 22);
            this.txtBrVrata.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(74, 446);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 16);
            this.label15.TabIndex = 29;
            this.label15.Text = "Godiste:";
            // 
            // txtMenjac
            // 
            this.txtMenjac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMenjac.Location = new System.Drawing.Point(622, 465);
            this.txtMenjac.Name = "txtMenjac";
            this.txtMenjac.ReadOnly = true;
            this.txtMenjac.Size = new System.Drawing.Size(182, 22);
            this.txtMenjac.TabIndex = 30;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(358, 446);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 16);
            this.label16.TabIndex = 31;
            this.label16.Text = "Broj vrata:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(619, 446);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 16);
            this.label17.TabIndex = 32;
            this.label17.Text = "Menjac:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(74, 503);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(150, 48);
            this.label18.TabIndex = 33;
            this.label18.Text = "Podaci o rezervaciji:\r\n\r\n\r\n";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(74, 518);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(126, 16);
            this.label19.TabIndex = 34;
            this.label19.Text = "Datum preuzimanja:";
            // 
            // txtDatPreuzimanje
            // 
            this.txtDatPreuzimanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatPreuzimanje.Location = new System.Drawing.Point(75, 537);
            this.txtDatPreuzimanje.Name = "txtDatPreuzimanje";
            this.txtDatPreuzimanje.ReadOnly = true;
            this.txtDatPreuzimanje.Size = new System.Drawing.Size(182, 22);
            this.txtDatPreuzimanje.TabIndex = 35;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(305, 518);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(105, 16);
            this.label20.TabIndex = 36;
            this.label20.Text = "Datum vracanja:\r\n";
            // 
            // txtDatVracanje
            // 
            this.txtDatVracanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatVracanje.Location = new System.Drawing.Point(308, 537);
            this.txtDatVracanje.Name = "txtDatVracanje";
            this.txtDatVracanje.ReadOnly = true;
            this.txtDatVracanje.Size = new System.Drawing.Size(182, 22);
            this.txtDatVracanje.TabIndex = 37;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(619, 518);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(112, 16);
            this.label21.TabIndex = 38;
            this.label21.Text = "Cena rezervacije:";
            // 
            // txtCena
            // 
            this.txtCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCena.Location = new System.Drawing.Point(622, 537);
            this.txtCena.Name = "txtCena";
            this.txtCena.ReadOnly = true;
            this.txtCena.Size = new System.Drawing.Size(182, 22);
            this.txtCena.TabIndex = 39;
            // 
            // btnUkini
            // 
            this.btnUkini.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUkini.Location = new System.Drawing.Point(75, 577);
            this.btnUkini.Name = "btnUkini";
            this.btnUkini.Size = new System.Drawing.Size(317, 32);
            this.btnUkini.TabIndex = 40;
            this.btnUkini.Text = "Ukini rezervaciju";
            this.btnUkini.UseVisualStyleBackColor = true;
            this.btnUkini.Click += new System.EventHandler(this.BtnUkini_Click);
            // 
            // btnNovaRez
            // 
            this.btnNovaRez.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaRez.Location = new System.Drawing.Point(504, 577);
            this.btnNovaRez.Name = "btnNovaRez";
            this.btnNovaRez.Size = new System.Drawing.Size(317, 32);
            this.btnNovaRez.TabIndex = 41;
            this.btnNovaRez.Text = "Nova rezervacija";
            this.btnNovaRez.UseVisualStyleBackColor = true;
            this.btnNovaRez.Click += new System.EventHandler(this.BtnNovaRez_Click);
            // 
            // Moje_Rezervacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(852, 630);
            this.Controls.Add(this.btnNovaRez);
            this.Controls.Add(this.btnUkini);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtDatVracanje);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtDatPreuzimanje);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtMenjac);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtBrVrata);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtGodiste);
            this.Controls.Add(this.txtPogon);
            this.Controls.Add(this.txtKaroserija);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtGorivo);
            this.Controls.Add(this.txtKubikaza);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDatRodjenja);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtJMBG);
            this.Controls.Add(this.txtPrezimeKupca);
            this.Controls.Add(this.txtImeKupca);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listboxRezervacije);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Moje_Rezervacije";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Moje_Rezervacije";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listboxRezervacije;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtImeKupca;
        private System.Windows.Forms.TextBox txtPrezimeKupca;
        private System.Windows.Forms.TextBox txtJMBG;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtDatRodjenja;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtKubikaza;
        private System.Windows.Forms.TextBox txtGorivo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtKaroserija;
        private System.Windows.Forms.TextBox txtPogon;
        private System.Windows.Forms.TextBox txtGodiste;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtBrVrata;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtMenjac;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtDatPreuzimanje;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtDatVracanje;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.Button btnUkini;
        private System.Windows.Forms.Button btnNovaRez;
    }
}