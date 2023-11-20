namespace Biblioteka
{
    partial class Form2
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
            this.RD_Korisnik = new System.Windows.Forms.RadioButton();
            this.RD_Knjiga = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RD_Evidencija = new System.Windows.Forms.RadioButton();
            this.GRP_Korisnik = new System.Windows.Forms.GroupBox();
            this.Txt_BrTel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_Adresa = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Prezime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Ime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GRP_Knjiga = new System.Windows.Forms.GroupBox();
            this.Txt_Izdavac = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_Naslov = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Txt_Autor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.GRP_Evidencija = new System.Windows.Forms.GroupBox();
            this.CMB_Naslov = new System.Windows.Forms.ComboBox();
            this.CMB_Email = new System.Windows.Forms.ComboBox();
            this.DTP_Vracanje = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.DTP_Podizanje = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Btn_Unos = new System.Windows.Forms.Button();
            this.Btn_Spremi = new System.Windows.Forms.Button();
            this.Btn_Otvori = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.GRP_Korisnik.SuspendLayout();
            this.GRP_Knjiga.SuspendLayout();
            this.GRP_Evidencija.SuspendLayout();
            this.SuspendLayout();
            // 
            // RD_Korisnik
            // 
            this.RD_Korisnik.AutoSize = true;
            this.RD_Korisnik.Location = new System.Drawing.Point(6, 23);
            this.RD_Korisnik.Name = "RD_Korisnik";
            this.RD_Korisnik.Size = new System.Drawing.Size(62, 17);
            this.RD_Korisnik.TabIndex = 0;
            this.RD_Korisnik.TabStop = true;
            this.RD_Korisnik.Text = "Korisnik";
            this.RD_Korisnik.UseVisualStyleBackColor = true;
            this.RD_Korisnik.CheckedChanged += new System.EventHandler(this.RD_Korisnik_CheckedChanged);
            // 
            // RD_Knjiga
            // 
            this.RD_Knjiga.AutoSize = true;
            this.RD_Knjiga.Location = new System.Drawing.Point(6, 46);
            this.RD_Knjiga.Name = "RD_Knjiga";
            this.RD_Knjiga.Size = new System.Drawing.Size(54, 17);
            this.RD_Knjiga.TabIndex = 1;
            this.RD_Knjiga.TabStop = true;
            this.RD_Knjiga.Text = "Knjiga";
            this.RD_Knjiga.UseVisualStyleBackColor = true;
            this.RD_Knjiga.CheckedChanged += new System.EventHandler(this.RD_Knjiga_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RD_Evidencija);
            this.groupBox1.Controls.Add(this.RD_Knjiga);
            this.groupBox1.Controls.Add(this.RD_Korisnik);
            this.groupBox1.Location = new System.Drawing.Point(251, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 103);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vrsta Unosa";
            // 
            // RD_Evidencija
            // 
            this.RD_Evidencija.AutoSize = true;
            this.RD_Evidencija.Location = new System.Drawing.Point(6, 69);
            this.RD_Evidencija.Name = "RD_Evidencija";
            this.RD_Evidencija.Size = new System.Drawing.Size(74, 17);
            this.RD_Evidencija.TabIndex = 2;
            this.RD_Evidencija.TabStop = true;
            this.RD_Evidencija.Text = "Evidencija";
            this.RD_Evidencija.UseVisualStyleBackColor = true;
            this.RD_Evidencija.CheckedChanged += new System.EventHandler(this.RD_Evidencija_CheckedChanged);
            // 
            // GRP_Korisnik
            // 
            this.GRP_Korisnik.Controls.Add(this.Txt_BrTel);
            this.GRP_Korisnik.Controls.Add(this.label6);
            this.GRP_Korisnik.Controls.Add(this.Txt_Adresa);
            this.GRP_Korisnik.Controls.Add(this.Label5);
            this.GRP_Korisnik.Controls.Add(this.Txt_Email);
            this.GRP_Korisnik.Controls.Add(this.label4);
            this.GRP_Korisnik.Controls.Add(this.Txt_Prezime);
            this.GRP_Korisnik.Controls.Add(this.label2);
            this.GRP_Korisnik.Controls.Add(this.Txt_Ime);
            this.GRP_Korisnik.Controls.Add(this.label1);
            this.GRP_Korisnik.Location = new System.Drawing.Point(12, 12);
            this.GRP_Korisnik.Name = "GRP_Korisnik";
            this.GRP_Korisnik.Size = new System.Drawing.Size(200, 246);
            this.GRP_Korisnik.TabIndex = 3;
            this.GRP_Korisnik.TabStop = false;
            this.GRP_Korisnik.Text = "Korisnik";
            this.GRP_Korisnik.Visible = false;
            // 
            // Txt_BrTel
            // 
            this.Txt_BrTel.Location = new System.Drawing.Point(6, 188);
            this.Txt_BrTel.Name = "Txt_BrTel";
            this.Txt_BrTel.Size = new System.Drawing.Size(100, 20);
            this.Txt_BrTel.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Broj telefona";
            // 
            // Txt_Adresa
            // 
            this.Txt_Adresa.Location = new System.Drawing.Point(6, 149);
            this.Txt_Adresa.Name = "Txt_Adresa";
            this.Txt_Adresa.Size = new System.Drawing.Size(100, 20);
            this.Txt_Adresa.TabIndex = 7;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(3, 133);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(40, 13);
            this.Label5.TabIndex = 6;
            this.Label5.Text = "Adresa";
            // 
            // Txt_Email
            // 
            this.Txt_Email.Location = new System.Drawing.Point(6, 110);
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(100, 20);
            this.Txt_Email.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email";
            // 
            // Txt_Prezime
            // 
            this.Txt_Prezime.Location = new System.Drawing.Point(6, 71);
            this.Txt_Prezime.Name = "Txt_Prezime";
            this.Txt_Prezime.Size = new System.Drawing.Size(100, 20);
            this.Txt_Prezime.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prezime";
            // 
            // Txt_Ime
            // 
            this.Txt_Ime.Location = new System.Drawing.Point(6, 32);
            this.Txt_Ime.Name = "Txt_Ime";
            this.Txt_Ime.Size = new System.Drawing.Size(100, 20);
            this.Txt_Ime.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime";
            // 
            // GRP_Knjiga
            // 
            this.GRP_Knjiga.Controls.Add(this.Txt_Izdavac);
            this.GRP_Knjiga.Controls.Add(this.label8);
            this.GRP_Knjiga.Controls.Add(this.Txt_Naslov);
            this.GRP_Knjiga.Controls.Add(this.label9);
            this.GRP_Knjiga.Controls.Add(this.Txt_Autor);
            this.GRP_Knjiga.Controls.Add(this.label10);
            this.GRP_Knjiga.Location = new System.Drawing.Point(12, 12);
            this.GRP_Knjiga.Name = "GRP_Knjiga";
            this.GRP_Knjiga.Size = new System.Drawing.Size(200, 154);
            this.GRP_Knjiga.TabIndex = 10;
            this.GRP_Knjiga.TabStop = false;
            this.GRP_Knjiga.Text = "Knjiga";
            this.GRP_Knjiga.Visible = false;
            // 
            // Txt_Izdavac
            // 
            this.Txt_Izdavac.Location = new System.Drawing.Point(6, 110);
            this.Txt_Izdavac.Name = "Txt_Izdavac";
            this.Txt_Izdavac.Size = new System.Drawing.Size(100, 20);
            this.Txt_Izdavac.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Izdavač";
            // 
            // Txt_Naslov
            // 
            this.Txt_Naslov.Location = new System.Drawing.Point(6, 71);
            this.Txt_Naslov.Name = "Txt_Naslov";
            this.Txt_Naslov.Size = new System.Drawing.Size(100, 20);
            this.Txt_Naslov.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Naslov";
            // 
            // Txt_Autor
            // 
            this.Txt_Autor.Location = new System.Drawing.Point(6, 32);
            this.Txt_Autor.Name = "Txt_Autor";
            this.Txt_Autor.Size = new System.Drawing.Size(100, 20);
            this.Txt_Autor.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Autor";
            // 
            // GRP_Evidencija
            // 
            this.GRP_Evidencija.Controls.Add(this.CMB_Naslov);
            this.GRP_Evidencija.Controls.Add(this.CMB_Email);
            this.GRP_Evidencija.Controls.Add(this.DTP_Vracanje);
            this.GRP_Evidencija.Controls.Add(this.label12);
            this.GRP_Evidencija.Controls.Add(this.DTP_Podizanje);
            this.GRP_Evidencija.Controls.Add(this.label3);
            this.GRP_Evidencija.Controls.Add(this.label7);
            this.GRP_Evidencija.Controls.Add(this.label11);
            this.GRP_Evidencija.Location = new System.Drawing.Point(12, 12);
            this.GRP_Evidencija.Name = "GRP_Evidencija";
            this.GRP_Evidencija.Size = new System.Drawing.Size(213, 185);
            this.GRP_Evidencija.TabIndex = 11;
            this.GRP_Evidencija.TabStop = false;
            this.GRP_Evidencija.Text = "Evidencija";
            this.GRP_Evidencija.Visible = false;
            // 
            // CMB_Naslov
            // 
            this.CMB_Naslov.FormattingEnabled = true;
            this.CMB_Naslov.Location = new System.Drawing.Point(6, 71);
            this.CMB_Naslov.Name = "CMB_Naslov";
            this.CMB_Naslov.Size = new System.Drawing.Size(121, 21);
            this.CMB_Naslov.TabIndex = 9;
            // 
            // CMB_Email
            // 
            this.CMB_Email.FormattingEnabled = true;
            this.CMB_Email.Location = new System.Drawing.Point(6, 32);
            this.CMB_Email.Name = "CMB_Email";
            this.CMB_Email.Size = new System.Drawing.Size(121, 21);
            this.CMB_Email.TabIndex = 8;
            // 
            // DTP_Vracanje
            // 
            this.DTP_Vracanje.Location = new System.Drawing.Point(6, 149);
            this.DTP_Vracanje.Name = "DTP_Vracanje";
            this.DTP_Vracanje.Size = new System.Drawing.Size(200, 20);
            this.DTP_Vracanje.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 133);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Datum vračanja";
            // 
            // DTP_Podizanje
            // 
            this.DTP_Podizanje.Location = new System.Drawing.Point(6, 110);
            this.DTP_Podizanje.Name = "DTP_Podizanje";
            this.DTP_Podizanje.Size = new System.Drawing.Size(200, 20);
            this.DTP_Podizanje.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Datum podizanja";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Naslov knjige";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Email od korisnika";
            // 
            // Btn_Unos
            // 
            this.Btn_Unos.Location = new System.Drawing.Point(12, 336);
            this.Btn_Unos.Name = "Btn_Unos";
            this.Btn_Unos.Size = new System.Drawing.Size(75, 23);
            this.Btn_Unos.TabIndex = 12;
            this.Btn_Unos.Text = "Unesi";
            this.Btn_Unos.UseVisualStyleBackColor = true;
            this.Btn_Unos.Click += new System.EventHandler(this.Btn_Unos_Click);
            // 
            // Btn_Spremi
            // 
            this.Btn_Spremi.Location = new System.Drawing.Point(376, 336);
            this.Btn_Spremi.Name = "Btn_Spremi";
            this.Btn_Spremi.Size = new System.Drawing.Size(75, 23);
            this.Btn_Spremi.TabIndex = 13;
            this.Btn_Spremi.Text = "Spremi";
            this.Btn_Spremi.UseVisualStyleBackColor = true;
            this.Btn_Spremi.Click += new System.EventHandler(this.Btn_Spremi_Click);
            // 
            // Btn_Otvori
            // 
            this.Btn_Otvori.Location = new System.Drawing.Point(194, 336);
            this.Btn_Otvori.Name = "Btn_Otvori";
            this.Btn_Otvori.Size = new System.Drawing.Size(75, 23);
            this.Btn_Otvori.TabIndex = 14;
            this.Btn_Otvori.Text = "Otvori";
            this.Btn_Otvori.UseVisualStyleBackColor = true;
            this.Btn_Otvori.Click += new System.EventHandler(this.Btn_Otvori_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 381);
            this.Controls.Add(this.Btn_Otvori);
            this.Controls.Add(this.Btn_Spremi);
            this.Controls.Add(this.Btn_Unos);
            this.Controls.Add(this.GRP_Evidencija);
            this.Controls.Add(this.GRP_Knjiga);
            this.Controls.Add(this.GRP_Korisnik);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "FormUnos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GRP_Korisnik.ResumeLayout(false);
            this.GRP_Korisnik.PerformLayout();
            this.GRP_Knjiga.ResumeLayout(false);
            this.GRP_Knjiga.PerformLayout();
            this.GRP_Evidencija.ResumeLayout(false);
            this.GRP_Evidencija.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton RD_Korisnik;
        private System.Windows.Forms.RadioButton RD_Knjiga;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RD_Evidencija;
        private System.Windows.Forms.GroupBox GRP_Korisnik;
        private System.Windows.Forms.TextBox Txt_BrTel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_Adresa;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.TextBox Txt_Email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Prezime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Ime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GRP_Knjiga;
        private System.Windows.Forms.TextBox Txt_Izdavac;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Txt_Naslov;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Txt_Autor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox GRP_Evidencija;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker DTP_Vracanje;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker DTP_Podizanje;
        private System.Windows.Forms.ComboBox CMB_Naslov;
        private System.Windows.Forms.ComboBox CMB_Email;
        private System.Windows.Forms.Button Btn_Unos;
        private System.Windows.Forms.Button Btn_Spremi;
        private System.Windows.Forms.Button Btn_Otvori;
    }
}