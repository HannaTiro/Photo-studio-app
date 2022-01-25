using PhotoStudio.Data.Requests.Grad;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoStudio.Data.Requests.Korisnik
{
    public class KorisnikRequest
    {
        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        // public int? TipKorisnikaId { get; set; }
        //public int? GradId { get; set; }
        public GradRequest Grad { get; set; }
    }
}
