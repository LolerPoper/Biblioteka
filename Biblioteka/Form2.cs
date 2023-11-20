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
using System.Windows.Forms.VisualStyles;
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
                Korisnik korisnik = new Korisnik(korisnik_ran, Txt_Email.Text, Txt_Ime.Text, Txt_Prezime.Text, Txt_Adresa.Text, Txt_BrTel.Text);
                korisnici.Add(korisnik);
                Txt_Ime.Clear();
                Txt_Prezime.Clear();
                Txt_Adresa.Clear();
                Txt_BrTel.Clear();
                Txt_Email.Clear();
                CMB_Email.Items.Add(korisnik.Email);

                XDocument Xml = new XDocument(new XElement("Korisnici",
                from xml in korisnici
                select new XElement("Korisnik",
                    new XAttribute("ID", xml.Korisnik_id),
                    new XAttribute("Email", xml.Email),
                    new XAttribute("Ime", xml.Ime),
                    new XAttribute("Prezime", xml.Prezime),
                    new XAttribute("Adresa", xml.Adresa),
                    new XAttribute("Broj_Telefona", xml.Broj_telefona))));

                string Korisnik_Path = "C:\\Users\\ucenik\\Documents\\Luka Radetic";
                Korisnik_Path = Environment.ExpandEnvironmentVariables(Korisnik_Path);
                string fileStream = Korisnik_Path + "\\Korisnici.xml";

                File.Delete(fileStream);
                File.AppendAllText(fileStream, Xml.ToString());
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
                CMB_Naslov.Items.Add(knjiga.Naslov);

                XDocument Xml = new XDocument(new XElement("Knjige",
                from xml in knjige
                select new XElement("Knjiga",
                    new XAttribute("ID", xml.Knjiga_id),
                    new XAttribute("Autor", xml.Autor),
                    new XAttribute("Naslov", xml.Naslov),
                    new XAttribute("Izdavač", xml.Izdavac))));

                string Knjiga_Path = "C:\\Users\\ucenik\\Documents\\Luka Radetic";
                Knjiga_Path = Environment.ExpandEnvironmentVariables(Knjiga_Path);
                string fileStream = Knjiga_Path + "\\Knjige.xml";

                File.Delete(fileStream);
                File.AppendAllText(fileStream, Xml.ToString());
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
            if (RD_Korisnik.Checked)
            {
                

                /*SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Xml File (*.xml)|*.xml";
                saveFileDialog.DefaultExt = "*.xml";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.FileName = "Korisnici";*/

                /*if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        writer.WriteLine(Xml.ToString());
                    }
                }*/
            }

            if (RD_Knjiga.Checked)
            {
                

                /*SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Xml File (*.xml)|*.xml";
                saveFileDialog.DefaultExt = "*.xml";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.FileName = "Knjige";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        writer.WriteLine(Xml.ToString());
                    }
                }*/
            }

            if (RD_Evidencija.Checked)
            {
                XDocument Xml = new XDocument(new XElement("Evidencije",
                from xml in evidencije
                select new XElement("Evidencija",
                    new XAttribute("Naziv_Knjige", xml.Naziv_knjige),
                    new XAttribute("Naziv_Korisnika", xml.Naziv_korisnika),
                    new XAttribute("Datum_Podizanja", xml.Datum_podizanja),
                    new XAttribute("Datum_Vracanja", xml.Datum_vracanja))));

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Xml File (*.xml)|*.xml";
                saveFileDialog.DefaultExt = "*.xml";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.FileName = "Evidencije";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        writer.WriteLine(Xml.ToString());
                    }
                }
            }
        }

        private void Btn_Otvori_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Xml File (*.xml)|*.xml";
            openFileDialog.DefaultExt = "*.xml";
            openFileDialog.FilterIndex = 1;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                {
                    if(RD_Evidencija.Checked)
                    {
                        XElement newXML = XElement.Load(reader);
                        foreach(XElement element in newXML.Elements())
                        {
                            Evidencija evidencija = new Evidencija(element.Attribute("Naziv_Knjige").Value, element.Attribute("Naziv_Korisnika").Value,
                                element.Attribute("Datum_Podizanja").Value, element.Attribute("Datum_Vracanja").Value);
                            evidencije.Add(evidencija);
                        }

                    }
                    if (RD_Korisnik.Checked)
                    {
                        XElement newXML = XElement.Load(reader);
                        foreach (XElement element in newXML.Elements())
                        {
                            Korisnik korisnik = new Korisnik(element.Attribute("ID").Value, element.Attribute("Email").Value,
                                element.Attribute("Ime").Value, element.Attribute("Prezime").Value, 
                                element.Attribute("Adresa").Value, element.Attribute("Broj_Telefona").Value);
                            korisnici.Add(korisnik);
                            CMB_Email.Items.Add(korisnik.Email);
                        }
                    }
                    if (RD_Knjiga.Checked)
                    {
                        XElement newXML = XElement.Load(reader);
                        foreach (XElement element in newXML.Elements())
                        {
                            Knjiga knjiga = new Knjiga(element.Attribute("ID").Value, element.Attribute("Autor").Value,
                                element.Attribute("Naslov").Value, element.Attribute("Izdavač").Value);
                            knjige.Add(knjiga);
                            CMB_Naslov.Items.Add(knjiga.Naslov);
                        }

                    }
                }
            }
        }
    }
}
