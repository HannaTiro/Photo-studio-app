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

        public virtual Fotograf Fotograf { get; set; }
        public virtual Korisnik Korisnik { get; set; }
    }
}
