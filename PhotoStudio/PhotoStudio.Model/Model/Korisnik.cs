﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoStudio.Data.Model
{
   public  class Korisnik
    {
        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public int? TipKorisnikaId { get; set; }
        public int? GradId { get; set; }

        public  Grad Grad { get; set; }
        public  TipKorisnika TipKorisnika { get; set; }
        //public virtual ICollection<Komentar> Komentars { get; set; }
        //public virtual ICollection<Rejting> Rejtings { get; set; }
        //public virtual ICollection<Rezervacija> Rezervacijas { get; set; }
    }
}
