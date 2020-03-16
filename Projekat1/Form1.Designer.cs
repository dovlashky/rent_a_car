namespace Projekat1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.radiobtnAdmin = new System.Windows.Forms.RadioButton();
            this.radiobtnKupac = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPrijava = new System.Windows.Forms.Button();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // radiobtnAdmin
            // 
            resources.ApplyResources(this.radiobtnAdmin, "radiobtnAdmin");
            this.radiobtnAdmin.Checked = true;
            this.radiobtnAdmin.Name = "radiobtnAdmin";
            this.radiobtnAdmin.TabStop = true;
            this.radiobtnAdmin.UseVisualStyleBackColor = true;
            this.radiobtnAdmin.CheckedChanged += new System.EventHandler(this.RadiobtnAdmin_CheckedChanged);
            // 
            // radiobtnKupac
            // 
            resources.ApplyResources(this.radiobtnKupac, "radiobtnKupac");
            this.radiobtnKupac.Name = "radiobtnKupac";
            this.radiobtnKupac.UseVisualStyleBackColor = true;
            this.radiobtnKupac.CheckedChanged += new System.EventHandler(this.RadiobtnKupac_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radiobtnAdmin);
            this.groupBox1.Controls.Add(this.radiobtnKupac);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPrijava);
            this.groupBox2.Controls.Add(this.txtLozinka);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtKorisnickoIme);
            this.groupBox2.Controls.Add(this.label1);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // btnPrijava
            // 
            resources.ApplyResources(this.btnPrijava, "btnPrijava");
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.UseVisualStyleBackColor = true;
            this.btnPrijava.Click += new System.EventHandler(this.BtnPrijava_Click);
            // 
            // txtLozinka
            // 
            resources.ApplyResources(this.txtLozinka, "txtLozinka");
            this.txtLozinka.Name = "txtLozinka";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txtKorisnickoIme
            // 
            resources.ApplyResources(this.txtKorisnickoIme, "txtKorisnickoIme");
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radiobtnAdmin;
        private System.Windows.Forms.RadioButton radiobtnKupac;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrijava;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
    }
}

