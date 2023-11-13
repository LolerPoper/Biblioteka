using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Biblioteka
{
    public partial class Form2 : Form
    {
        List<Korisnik> korisnici = new List<Korisnik>();
        List<Knjiga> knjige = new List<Knjiga>();
        List<Evidencija> evidencije = new List<Evidencija>();
        public Form2()
        {
            InitializeComponent();
        }

        private void RD_Korisnik_CheckedChanged(object sender, EventArgs e)
        {
            if(RD_Korisnik.Checked)
            {
                GRP_Korisnik.Show();
            }
            else
            {
                GRP_Korisnik.Hide();
            }
        }

        private void RD_Knjiga_CheckedChanged(object sender, EventArgs e)
        {
            if (RD_Knjiga.Checked)
            {
                GRP_Knjiga.Show();
            }
            else
            {
                GRP_Knjiga.Hide();
            }
        }

        private void RD_Evidencija_CheckedChanged(object sender, EventArgs e)
        {
            if (RD_Evidencija.Checked)
            {
                GRP_Evidencija.Show();
            }
            else
            {
                GRP_Evidencija.Hide();
            }
        }

        private void Btn_Unos_Click(object sender, EventArgs e)
        {
            if (RD_Korisnik.Checked)
            {
            Rando_Korisnik: Random doRan = new Random();
                string korisnik_ran = Convert.ToString(doRan.Next());
                foreach (Korisnik kor in korisnici)
                {
                    if(kor.Korisnik_id == korisnik_ran)
                    {
                        goto Rando_Korisnik;
                    }
                }
                Korisnik korisnik = new Korisnik(korisnik_ran, Txt_Email.Text, Txt_Ime.Text, Txt_Prezime.Text, Txt_Adresa.Text, Convert.ToInt32(Txt_BrTel.Text));
                korisnici.Add(korisnik);
                Txt_Ime.Clear();
                Txt_Prezime.Clear();
                Txt_Adresa.Clear();
                Txt_BrTel.Clear();
                Txt_Email.Clear();
            }

            if (RD_Knjiga.Checked)
            {
            Rando_Knjiga: Random doRan = new Random();
                string knjiga_ran = Convert.ToString(doRan.Next());
                foreach (Knjiga knj in knjige)
                {
                    if (knj.Knjiga_id == knjiga_ran)
                    {
                        goto Rando_Knjiga;
                    }
                }
                Knjiga knjiga = new Knjiga(knjiga_ran, Txt_Autor.Text, Txt_Naslov.Text, Txt_Izdavac.Text);
                knjige.Add(knjiga);
                Txt_Autor.Clear();
                Txt_Naslov.Clear();
                Txt_Izdavac.Clear();
            }

            if (RD_Evidencija.Checked)
            {
                Evidencija evidencija = new Evidencija(CMB_Naslov.Text, CMB_Email.Text, DTP_Podizanje.Text, DTP_Vracanje.Text);
                evidencije.Add(evidencija);
                CMB_Naslov.Text = null;
                CMB_Email.Text = null;

            }
        }

        private void Btn_Spremi_Click(object sender, EventArgs e)
        {
            /*if (RD_Korisnik.Checked)
            {
                XDocument Xml = new XDocument(new XElement("Vozilo",
                from xml in korisnici
                select new XElement("Korisnik",
                    new XAttribute("ID", xml.Korisnik_id),
                    new XAttribute("GodinaProizvodnje", xml.GodProiz),
                    new XAttribute("Kategorija", xml.Kategorija))));

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Xml File (*.xml)|*.xml";
                saveFileDialog.DefaultExt = "*.xml";
                saveFileDialog.FilterIndex = 1;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        writer.WriteLine(Xml.ToString());
                    }
                }
            }

            if (RD_Knjiga.Checked)
            {

            }

            if (RD_Evidencija.Checked)
            {

            }*/
        }
    }
}
