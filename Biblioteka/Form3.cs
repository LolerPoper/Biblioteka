using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Biblioteka
{
    public partial class Form3 : Form
    {
        List<Korisnik> korisnici = new List<Korisnik>();
        List<Knjiga> knjige = new List<Knjiga>();
        List<Evidencija> evidencije = new List<Evidencija>();
        public Form3()
        {
            InitializeComponent();

            string Korisnik_Path = "C:\\Users\\ucenik\\Documents\\Luka Radetic";
            Korisnik_Path = Environment.ExpandEnvironmentVariables(Korisnik_Path);
            string fileStreamKor = Korisnik_Path + "\\Korisnici.xml";

            using (StreamReader reader = new StreamReader(fileStreamKor))
            {

                XElement newXML = XElement.Load(reader);
                foreach (XElement element in newXML.Elements())
                {
                    Korisnik korisnik = new Korisnik(element.Attribute("ID").Value, element.Attribute("Email").Value,
                        element.Attribute("Ime").Value, element.Attribute("Prezime").Value,
                        element.Attribute("Adresa").Value, element.Attribute("Broj_Telefona").Value);
                    korisnici.Add(korisnik);
                }
            }

            string Knjiga_Path = "C:\\Users\\ucenik\\Documents\\Luka Radetic";
            Knjiga_Path = Environment.ExpandEnvironmentVariables(Knjiga_Path);
            string fileStreamKnjg = Knjiga_Path + "\\Knjige.xml";

            using (StreamReader reader = new StreamReader(fileStreamKnjg))
            {
                XElement newXML = XElement.Load(reader);
                foreach (XElement element in newXML.Elements())
                {
                    Knjiga knjiga = new Knjiga(element.Attribute("ID").Value, element.Attribute("Autor").Value,
                        element.Attribute("Naslov").Value, element.Attribute("Izdavač").Value);
                    knjige.Add(knjiga);
                }
            }

            string Evid_Path = "C:\\Users\\ucenik\\Documents\\Luka Radetic";
            Evid_Path = Environment.ExpandEnvironmentVariables(Evid_Path);
            string fileStreamEvid = Evid_Path + "\\Evidencije.xml";

            using (StreamReader reader = new StreamReader(fileStreamEvid))
            {
                XElement newXML = XElement.Load(reader);
                foreach (XElement element in newXML.Elements())
                {
                    Evidencija evidencija = new Evidencija(element.Attribute("Naziv_Knjige").Value, element.Attribute("Naziv_Korisnika").Value,
                        element.Attribute("Datum_Podizanja").Value, element.Attribute("Datum_Vracanja").Value);
                    evidencije.Add(evidencija);
                }
            }
            Trazi();
        }

        private void Btn_Trazi_Click(object sender, EventArgs e)
        {
            Trazi();
        }
            private void Trazi()
        {
            Lst_Box.Items.Clear();
            string search = Txt_Trazi.Text;
            Lst_Box.Items.Add("Korisnici");
            foreach (Korisnik k in korisnici)
            {
                if(k.Korisnik_id.StartsWith(search) == true || k.Ime.StartsWith(search) || k.Prezime.StartsWith(search) ||
                    k.Adresa.StartsWith(search) || k.Email.StartsWith(search) || k.Broj_telefona.StartsWith(search) || search == "") 
                {
                    Lst_Box.Items.Add(k.ToString());
                }
            }

            Lst_Box.Items.Add("");
            Lst_Box.Items.Add("Knjige");
            foreach (Knjiga k in knjige)
            {
                if (k.Knjiga_id.StartsWith(search) == true || k.Autor.StartsWith(search) || k.Izdavac.StartsWith(search) ||
                    k.Naslov.StartsWith(search) || search == "")
                {
                    Lst_Box.Items.Add(k.ToString());
                }
            }

            Lst_Box.Items.Add("");
            Lst_Box.Items.Add("Evidencije");
            foreach (Evidencija k in evidencije)
            {
                if (k.Naziv_knjige.StartsWith(search) == true || k.Naziv_korisnika.StartsWith(search) || k.Datum_podizanja.StartsWith(search) ||
                    k.Datum_vracanja.StartsWith(search) || search == "")
                {
                    Lst_Box.Items.Add(k.ToString());
                }
            }
        }
    }
}
