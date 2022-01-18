using System;
using System.Collections.Generic;

#nullable disable

namespace PhotoStudio.Database
{
    public partial class Korisnik
    {
        public Korisnik()
        {
            Komentars = new HashSet<Komentar>();
            Rejtings = new HashSet<Rejting>();
            Rezervacijas = new HashSet<Rezervacija>();
        }

        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string PasswordSalt { get; set; }
        public string PasswordHash { get; set; }
        public int? TipKorisnikaId { get; set; }
        public int? GradId { get; set; }

        public virtual Grad Grad { get; set; }
        public virtual TipKorisnika TipKorisnika { get; set; }
        public virtual ICollection<Komentar> Komentars { get; set; }
        public virtual ICollection<Rejting> Rejtings { get; set; }
        public virtual ICollection<Rezervacija> Rezervacijas { get; set; }
    }
}
