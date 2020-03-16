namespace Projekat1
{
    partial class FrmRezervacija
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
            this.cmbMarka = new System.Windows.Forms.ComboBox();
            this.cmbKubikaza = new System.Windows.Forms.ComboBox();
            this.cmbGorivo = new System.Windows.Forms.ComboBox();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.cmbKaroserija = new System.Windows.Forms.ComboBox();
            this.cmbPogon = new System.Windows.Forms.ComboBox();
            this.cmbGodiste = new System.Windows.Forms.ComboBox();
            this.cmbBrVrata = new System.Windows.Forms.ComboBox();
            this.cmbMenjac = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnPrikaziTermine = new System.Windows.Forms.Button();
            this.txtPrikazTermina = new System.Windows.Forms.TextBox();
            this.dateTimePreuzimanje = new System.Windows.Forms.DateTimePicker();
            this.dateTimeVracanje = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtUkupnaCena = new System.Windows.Forms.TextBox();
            this.btnRezervisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbMarka
            // 
            this.cmbMarka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarka.FormattingEnabled = true;
            this.cmbMarka.Location = new System.Drawing.Point(43, 51);
            this.cmbMarka.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(211, 24);
            this.cmbMarka.TabIndex = 0;
            this.cmbMarka.SelectedValueChanged += new System.EventHandler(this.CmbMarka_SelectedValueChanged);
            // 
            // cmbKubikaza
            // 
            this.cmbKubikaza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKubikaza.FormattingEnabled = true;
            this.cmbKubikaza.Location = new System.Drawing.Point(331, 51);
            this.cmbKubikaza.Margin = new System.Windows.Forms.Padding(4);
            this.cmbKubikaza.Name = "cmbKubikaza";
            this.cmbKubikaza.Size = new System.Drawing.Size(211, 24);
            this.cmbKubikaza.TabIndex = 1;
            this.cmbKubikaza.SelectedValueChanged += new System.EventHandler(this.CmbKubikaza_SelectedValueChanged);
            // 
            // cmbGorivo
            // 
            this.cmbGorivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGorivo.FormattingEnabled = true;
            this.cmbGorivo.Location = new System.Drawing.Point(609, 51);
            this.cmbGorivo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbGorivo.Name = "cmbGorivo";
            this.cmbGorivo.Size = new System.Drawing.Size(211, 24);
            this.cmbGorivo.TabIndex = 2;
            this.cmbGorivo.SelectedValueChanged += new System.EventHandler(this.CmbGorivo_SelectedValueChanged);
            // 
            // cmbModel
            // 
            this.cmbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(43, 126);
            this.cmbModel.Margin = new System.Windows.Forms.Padding(4);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(211, 24);
            this.cmbModel.TabIndex = 3;
            this.cmbModel.SelectedValueChanged += new System.EventHandler(this.CmbModel_SelectedValueChanged);
            // 
            // cmbKaroserija
            // 
            this.cmbKaroserija.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKaroserija.FormattingEnabled = true;
            this.cmbKaroserija.Location = new System.Drawing.Point(331, 126);
            this.cmbKaroserija.Margin = new System.Windows.Forms.Padding(4);
            this.cmbKaroserija.Name = "cmbKaroserija";
            this.cmbKaroserija.Size = new System.Drawing.Size(211, 24);
            this.cmbKaroserija.TabIndex = 4;
            this.cmbKaroserija.SelectedValueChanged += new System.EventHandler(this.CmbKaroserija_SelectedValueChanged);
            // 
            // cmbPogon
            // 
            this.cmbPogon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPogon.FormattingEnabled = true;
            this.cmbPogon.Location = new System.Drawing.Point(609, 126);
            this.cmbPogon.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPogon.Name = "cmbPogon";
            this.cmbPogon.Size = new System.Drawing.Size(211, 24);
            this.cmbPogon.TabIndex = 5;
            this.cmbPogon.SelectedValueChanged += new System.EventHandler(this.CmbPogon_SelectedValueChanged);
            // 
            // cmbGodiste
            // 
            this.cmbGodiste.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGodiste.FormattingEnabled = true;
            this.cmbGodiste.Location = new System.Drawing.Point(43, 199);
            this.cmbGodiste.Margin = new System.Windows.Forms.Padding(4);
            this.cmbGodiste.Name = "cmbGodiste";
            this.cmbGodiste.Size = new System.Drawing.Size(211, 24);
            this.cmbGodiste.TabIndex = 6;
            this.cmbGodiste.SelectedValueChanged += new System.EventHandler(this.CmbGodiste_SelectedValueChanged);
            // 
            // cmbBrVrata
            // 
            this.cmbBrVrata.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrVrata.FormattingEnabled = true;
            this.cmbBrVrata.Location = new System.Drawing.Point(331, 195);
            this.cmbBrVrata.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBrVrata.Name = "cmbBrVrata";
            this.cmbBrVrata.Size = new System.Drawing.Size(211, 24);
            this.cmbBrVrata.TabIndex = 7;
            this.cmbBrVrata.SelectedValueChanged += new System.EventHandler(this.CmbBrVrata_SelectedValueChanged);
            // 
            // cmbMenjac
            // 
            this.cmbMenjac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMenjac.FormattingEnabled = true;
            this.cmbMenjac.Location = new System.Drawing.Point(609, 195);
            this.cmbMenjac.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMenjac.Name = "cmbMenjac";
            this.cmbMenjac.Size = new System.Drawing.Size(211, 24);
            this.cmbMenjac.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Odaberite marku:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(327, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Odaberite kubikazu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(605, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Odaberite gorivo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Odaberite model:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(327, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Odaberite karoseriju:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(605, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Odaberite pogon:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(44, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Odaberite godiste:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(330, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Odaberite broj vrata:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(605, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Odaberite menjac:";
            // 
            // btnPrikaziTermine
            // 
            this.btnPrikaziTermine.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikaziTermine.Location = new System.Drawing.Point(43, 230);
            this.btnPrikaziTermine.Name = "btnPrikaziTermine";
            this.btnPrikaziTermine.Size = new System.Drawing.Size(777, 57);
            this.btnPrikaziTermine.TabIndex = 18;
            this.btnPrikaziTermine.Text = "Prikazi dostupne termine odabranog automobila:";
            this.btnPrikaziTermine.UseVisualStyleBackColor = true;
            this.btnPrikaziTermine.Click += new System.EventHandler(this.BtnPrikaziTermine_Click);
            // 
            // txtPrikazTermina
            // 
            this.txtPrikazTermina.Location = new System.Drawing.Point(43, 293);
            this.txtPrikazTermina.Multiline = true;
            this.txtPrikazTermina.Name = "txtPrikazTermina";
            this.txtPrikazTermina.Size = new System.Drawing.Size(777, 196);
            this.txtPrikazTermina.TabIndex = 19;
            // 
            // dateTimePreuzimanje
            // 
            this.dateTimePreuzimanje.Location = new System.Drawing.Point(43, 511);
            this.dateTimePreuzimanje.Name = "dateTimePreuzimanje";
            this.dateTimePreuzimanje.Size = new System.Drawing.Size(235, 22);
            this.dateTimePreuzimanje.TabIndex = 20;
            this.dateTimePreuzimanje.ValueChanged += new System.EventHandler(this.DateTimePreuzimanje_ValueChanged);
            // 
            // dateTimeVracanje
            // 
            this.dateTimeVracanje.Location = new System.Drawing.Point(47, 573);
            this.dateTimeVracanje.Name = "dateTimeVracanje";
            this.dateTimeVracanje.Size = new System.Drawing.Size(231, 22);
            this.dateTimeVracanje.TabIndex = 21;
            this.dateTimeVracanje.ValueChanged += new System.EventHandler(this.DateTimeVracanje_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(45, 492);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(250, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Odaberite datum preuzimanja:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(45, 550);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(220, 20);
            this.label12.TabIndex = 24;
            this.label12.Text = "Odaberite datum vracanja:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(476, 530);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 40);
            this.label11.TabIndex = 25;
            this.label11.Text = "Ukupna cena \r\nrezervacije:";
            // 
            // txtUkupnaCena
            // 
            this.txtUkupnaCena.Location = new System.Drawing.Point(480, 573);
            this.txtUkupnaCena.Name = "txtUkupnaCena";
            this.txtUkupnaCena.ReadOnly = true;
            this.txtUkupnaCena.Size = new System.Drawing.Size(116, 22);
            this.txtUkupnaCena.TabIndex = 26;
            // 
            // btnRezervisi
            // 
            this.btnRezervisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRezervisi.Location = new System.Drawing.Point(49, 610);
            this.btnRezervisi.Name = "btnRezervisi";
            this.btnRezervisi.Size = new System.Drawing.Size(777, 57);
            this.btnRezervisi.TabIndex = 27;
            this.btnRezervisi.Text = "Rezervisi\r\n";
            this.btnRezervisi.UseVisualStyleBackColor = true;
            this.btnRezervisi.Click += new System.EventHandler(this.BtnRezervisi_Click);
            // 
            // FrmRezervacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(874, 695);
            this.Controls.Add(this.btnRezervisi);
            this.Controls.Add(this.txtUkupnaCena);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateTimeVracanje);
            this.Controls.Add(this.dateTimePreuzimanje);
            this.Controls.Add(this.txtPrikazTermina);
            this.Controls.Add(this.btnPrikaziTermine);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMenjac);
            this.Controls.Add(this.cmbBrVrata);
            this.Controls.Add(this.cmbGodiste);
            this.Controls.Add(this.cmbPogon);
            this.Controls.Add(this.cmbKaroserija);
            this.Controls.Add(this.cmbModel);
            this.Controls.Add(this.cmbGorivo);
            this.Controls.Add(this.cmbKubikaza);
            this.Controls.Add(this.cmbMarka);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmRezervacija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRezervacija";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMarka;
        private System.Windows.Forms.ComboBox cmbKubikaza;
        private System.Windows.Forms.ComboBox cmbGorivo;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.ComboBox cmbKaroserija;
        private System.Windows.Forms.ComboBox cmbPogon;
        private System.Windows.Forms.ComboBox cmbGodiste;
        private System.Windows.Forms.ComboBox cmbBrVrata;
        private System.Windows.Forms.ComboBox cmbMenjac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnPrikaziTermine;
        private System.Windows.Forms.TextBox txtPrikazTermina;
        private System.Windows.Forms.DateTimePicker dateTimePreuzimanje;
        private System.Windows.Forms.DateTimePicker dateTimeVracanje;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtUkupnaCena;
        private System.Windows.Forms.Button btnRezervisi;
    }
}