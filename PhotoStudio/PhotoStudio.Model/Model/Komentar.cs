using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoStudio.Data.Model
{
    public class Komentar
    {
        public int KomentarId { get; set; }
        public string Opis { get; set; }
        public DateTime? Datum { get; set; }
        public int? KorisnikId { get; set; }
        public int? FotografId { get; set; }

       public  Fotograf Fotograf { get; set; }
        public  Korisnik Korisnik { get; set; }
    }
}
