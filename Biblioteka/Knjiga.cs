using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Biblioteka
{
    internal class Knjiga
    {
        string knjiga_id, autor, naslov, izdavac;

        public Knjiga(string knjiga_id, string autor, string naslov, string izdavac)
        {
            Knjiga_id = knjiga_id;
            Autor = autor;
            Naslov = naslov;
            Izdavac = izdavac;
        }

        public string Knjiga_id { get => knjiga_id; set => knjiga_id = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Naslov { get => naslov; set => naslov = value; }
        public string Izdavac { get => izdavac; set => izdavac = value; }

        public override string ToString()
        {
            return "ID: " + Knjiga_id + " Naslov: " + Naslov + " Autor: " + Autor
                + " Izdavač: " + Izdavac;
        }
    }
}
