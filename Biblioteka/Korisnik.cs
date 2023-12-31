﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    internal class Korisnik
    {
        string korisnik_id, ime, prezime, adresa, email, broj_telefona;

        public string Korisnik_id { get => korisnik_id; set => korisnik_id = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Adresa { get => adresa; set => adresa = value; }
        public string Broj_telefona { get => broj_telefona; set => broj_telefona = value; }
        public string Email { get => email; set => email = value; }

        public Korisnik(string korisnik_id, string email , string ime, string prezime, string adresa, string broj_telefona)
        {
            Korisnik_id = korisnik_id;
            Ime = ime;
            Prezime = prezime;
            Adresa = adresa;
            Broj_telefona = broj_telefona;
            Email = email;
        }

        public override string ToString()
        {
            return "ID: " + Korisnik_id + " Email: " + Email + " Ime: " + Ime + " Prezime: " + Prezime
                + " Adresa: " + Adresa + " Broj telefona: " + Broj_telefona;
        }
    }
}
